using AutoService.Models;
using AutoService.Services;
using MaterialSkin;
using MaterialSkin.Controls;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AutoService
{
    public partial class AddRepairForm : MaterialForm
    {
        private readonly IServiceRecordService _recordSvc;
        private readonly IMechanicService _mechSvc;
        private readonly ICarService _carSvc;
        private readonly int _carId;
        private readonly ErrorProvider _errors = new ErrorProvider();

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

            // never let the icon blink
            _errors.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            // wire up per-field validation
            dtpDate.Validating += DtpDate_Validating;
            txtDescription.Validating += TxtDescription_Validating;
            nudCost.Validating += NumCost_Validating;
            cmbMechanics.Validating += CmbMechanic_Validating;
            cmbExistingCars.Validating += CmbCarSelection_Validating;

            // whenever any field changes, re–enable Save if all are valid
            dtpDate.ValueChanged += (s, e) => btnSave.Enabled = ValidateChildren();
            txtDescription.TextChanged += (s, e) => btnSave.Enabled = ValidateChildren();
            nudCost.ValueChanged += (s, e) => btnSave.Enabled = ValidateChildren();
            cmbMechanics.SelectedIndexChanged += (s, e) => btnSave.Enabled = ValidateChildren();
            cmbExistingCars.SelectedIndexChanged += (s, e) => btnSave.Enabled = ValidateChildren();

            // start disabled
            btnSave.Enabled = false;

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

        private void DtpDate_Validating(object sender, CancelEventArgs e)
        {
            var rec = new ServiceRecord { Date = dtpDate.Value };
            var ctx = new ValidationContext(rec) { MemberName = nameof(ServiceRecord.Date) };

            try
            {
                Validator.ValidateProperty(rec.Date, ctx);
                _errors.SetError(dtpDate, "");
            }
            catch (ValidationException ex)
            {
                _errors.SetError(dtpDate, ex.Message);
                e.Cancel = true;
            }
        }

        private void TxtDescription_Validating(object sender, CancelEventArgs e)
        {
            var rec = new ServiceRecord { Description = txtDescription.Text.Trim() };
            var ctx = new ValidationContext(rec) { MemberName = nameof(ServiceRecord.Description) };

            try
            {
                Validator.ValidateProperty(rec.Description, ctx);
                _errors.SetError(txtDescription, "");
            }
            catch (ValidationException ex)
            {
                _errors.SetError(txtDescription, ex.Message);
                e.Cancel = true;
            }
        }

        private void NumCost_Validating(object sender, CancelEventArgs e)
        {
            var rec = new ServiceRecord { Cost = nudCost.Value };
            var ctx = new ValidationContext(rec) { MemberName = nameof(ServiceRecord.Cost) };

            try
            {
                Validator.ValidateProperty(rec.Cost, ctx);
                _errors.SetError(nudCost, "");
            }
            catch (ValidationException ex)
            {
                _errors.SetError(nudCost, ex.Message);
                e.Cancel = true;
            }
        }

        private void CmbMechanic_Validating(object sender, CancelEventArgs e)
        {
            if (cmbMechanics.SelectedItem is null)
            {
                _errors.SetError(cmbMechanics, "Please choose a mechanic");
                e.Cancel = true;
            }
            else
            {
                _errors.SetError(cmbMechanics, "");
            }
        }

        private void CmbCarSelection_Validating(object sender, CancelEventArgs e)
        {
            // if "Existing Car" mode:
            if (rbExistingCar.Checked && cmbExistingCars.SelectedItem is null)
            {
                _errors.SetError(cmbExistingCars, "Please select an existing car");
                e.Cancel = true;
            }
            else
            {
                _errors.SetError(cmbExistingCars, "");
            }
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
            // run *all* the Validating handlers
            if (!ValidateChildren())
            {
                MessageBox.Show(
                    "Please fix the highlighted errors before saving.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // map to your entity
            var rec = new ServiceRecord
            {
                Date = dtpDate.Value,
                Description = txtDescription.Text.Trim(),
                Cost = nudCost.Value,
                MechanicId = ((Mechanic)cmbMechanics.SelectedItem).Id,
                CarId = ((Car)cmbExistingCars.SelectedItem).Id
                // …or handle NewCar fields…
            };

            await _recordSvc.AddAsync(rec);
            DialogResult = DialogResult.OK;
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
