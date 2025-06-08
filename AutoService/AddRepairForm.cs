using AutoService.Models;
using AutoService.Services;
using MaterialSkin;
using MaterialSkin.Controls;

namespace AutoService
{
    public partial class AddRepairForm : MaterialForm
    {
        private readonly IServiceRecordService _recordSvc;
        private readonly IMechanicService _mechSvc;
        private readonly ICarService _carSvc;
        private readonly int _carId;

        public AddRepairForm(
            IServiceRecordService recordSvc,
            IMechanicService mechSvc,
            ICarService carSvc,
            int? carId = null)
        {
            InitializeComponent();

            var mgr = MaterialSkinManager.Instance;
            mgr.AddFormToManage(this);
            mgr.Theme = MaterialSkinManager.Themes.LIGHT;     
            mgr.ColorScheme = new ColorScheme(
                Primary.Blue600, Primary.Blue900,
                Primary.Blue100, Accent.LightBlue200,
                TextShade.WHITE
            );

            _recordSvc = recordSvc;
            _mechSvc = mechSvc;
            _carSvc = carSvc;

            this.Load += AddRepairForm_Load;

            // Dissapering effect
            rbNewCar.CheckedChanged += rbNewCar_CheckedChanged;
            rbExistingCar.CheckedChanged += rbNewCar_CheckedChanged;
            rbExistingCar.Checked = true;
            rbNewCar_CheckedChanged(rbNewCar, EventArgs.Empty);

            dtpDate.Value = DateTime.Today;
        }

        private async Task LoadMechanicsAsync()
        {
            var mechs = await _mechSvc.GetAllAsync();
            cmbMechanics.DisplayMember = "Name";
            cmbMechanics.ValueMember = "Id";
            cmbMechanics.DataSource = mechs;
        }

        private async Task LoadCarsAsync(int? preselectId)
        {
            var cars = await _carSvc.GetAllAsync();
            cmbExistingCars.DisplayMember = "LicensePlate";
            cmbExistingCars.ValueMember = "Id";
            cmbExistingCars.DataSource = cars;
            if (preselectId.HasValue)
                cmbExistingCars.SelectedValue = preselectId.Value;
        }

        private async void AddRepairForm_Load(object sender, EventArgs e)
        {
            await LoadMechanicsAsync();

            await LoadCarsAsync(_carId);
        }

        private void rbNewCar_CheckedChanged(object sender, EventArgs e)
        {
            bool isNew = rbNewCar.Checked;
            cmbExistingCars.Visible = !isNew;
            lblExistingCar.Visible = !isNew;
            panelNewCarFields.Visible = isNew;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            int carId;

            if (rbNewCar.Checked)
            {
                // 1) Create the new car
                var newCar = new Car
                {
                    LicensePlate = txtLicensePlate.Text.Trim(),
                    VIN = txtVIN.Text.Trim(),
                    Make = txtMake.Text.Trim(),
                    Model = txtModel.Text.Trim(),
                    Year = (int)nudYear.Value
                };
                await _carSvc.AddAsync(newCar);
                carId = newCar.Id;
            }
            else
            {
                // 2) Use selected existing car
                if (cmbExistingCars.SelectedValue is not int existingId)
                {
                    MessageBox.Show("Please choose a car or add a new car.");
                    return;
                }
                carId = existingId;
            }

            // 3) Now create the service record for that carId
            if (cmbMechanics.SelectedValue is not int mechId)
            {
                MessageBox.Show("Select a mechanic.");
                return;
            }

            var record = new ServiceRecord
            {
                CarId = carId,
                MechanicId = mechId,
                Date = dtpDate.Value,
                Description = txtDescription.Text.Trim(),
                Cost = nudCost.Value
            };
            await _recordSvc.AddAsync(record);

            DialogResult = DialogResult.OK;
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
