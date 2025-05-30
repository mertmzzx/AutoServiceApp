using AutoService.Models;
using AutoService.Services;

namespace AutoService
{
    public partial class Form1 : Form
    {
        private readonly IMechanicService _mechService;
        private readonly ICarService _carService;
        private readonly IServiceRecordService _recordService;
        private readonly IPdfExportService _pdfService;
        private List<Car> _allCars = new List<Car>();

        public Form1(IMechanicService mechService, ICarService carService, IServiceRecordService recordService, IPdfExportService pdfService)
        {
            InitializeComponent();

            _mechService = mechService;
            _carService = carService;
            _recordService = recordService;
            _pdfService = pdfService;

            ConfigureRepairsGrid();
        }

        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            await LoadCarsAsync();
            if (cmbCars.Items.Count > 0)
                cmbCars.SelectedIndex = 0;

            await LoadRepairsAsync();

            cmbCars.SelectedIndexChanged += async (_, __) => await LoadRepairsAsync();
            
        }

        private void ConfigureRepairsGrid()
        {
            dgvRepairs.Columns.Clear();

            // hidden Id column
            dgvRepairs.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(RepairViewModel.Id),
                Name = "Id",
                Visible = false
            });

            // Date column
            dgvRepairs.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(RepairViewModel.Date),
                HeaderText = "Date",
                DefaultCellStyle = { Format = "d" }
            });

            // Description
            dgvRepairs.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(RepairViewModel.Description),
                HeaderText = "Description",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            // Cost
            dgvRepairs.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(RepairViewModel.Cost),
                HeaderText = "Cost",
                DefaultCellStyle = { Format = "C" },
                Width = 80
            });

            // CarPlate
            dgvRepairs.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(RepairViewModel.CarPlate),
                HeaderText = "Car",
                Width = 100
            });

            // MechanicName
            dgvRepairs.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(RepairViewModel.MechanicName),
                HeaderText = "Mechanic",
                Width = 120
            });

            dgvRepairs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRepairs.MultiSelect = false;
        }

        private async Task LoadMechanicsAsync()
        {
            var list = await _mechService.GetAllAsync();
            dgvMechanics.DataSource = list;
        }

        private async Task LoadCarsAsync()
        {
            _allCars = (await _carService.GetAllAsync()).ToList();

            cmbCars.DisplayMember = "LicensePlate";
            cmbCars.ValueMember = "Id";
            cmbCars.DataSource = _allCars;

            // set up autocomplete 
            cmbCars.DropDownStyle = ComboBoxStyle.DropDown;
            cmbCars.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCars.AutoCompleteSource = AutoCompleteSource.CustomSource;

            var acs = new AutoCompleteStringCollection();
            acs.AddRange(_allCars.Select(c => c.LicensePlate).ToArray());
            cmbCars.AutoCompleteCustomSource = acs;
        }

        private async Task LoadRepairsAsync()
        {
            dgvRepairs.DataSource = null;

            if (cmbCars.SelectedValue is int carId)
            {
                var records = await _recordService.GetByCarIdAsync(carId);
                var vmList = records.Select(r => new RepairViewModel
                {
                    Id = r.Id,
                    Date = r.Date,
                    Description = r.Description,
                    Cost = r.Cost,
                    CarPlate = r.Car.LicensePlate,
                    MechanicName = r.Mechanic.Name
                }).ToList();

                dgvRepairs.AutoGenerateColumns = false;
                dgvRepairs.DataSource = vmList;
            }
        }

        // Mechanic Tab
        private void btnAddMechanic_Click(object sender, EventArgs e)
        {
            using var dlg = new AddMechanicForm(_mechService);
            if (dlg.ShowDialog() == DialogResult.OK)
                LoadMechanicsAsync();
        }

        private void btnEditMechanic_Click(object sender, EventArgs e)
        {
            if (dgvMechanics.CurrentRow?.DataBoundItem is Mechanic mech)
            {
                using var dlg = new AddMechanicForm(_mechService, mech);
                if (dlg.ShowDialog() == DialogResult.OK)
                    LoadMechanicsAsync();
            }
        }

        private async void btnDeleteMechanic_ClickAsync(object sender, EventArgs e)
        {
            if (dgvMechanics.CurrentRow?.DataBoundItem is Mechanic mech)
            {
                await _mechService.DeleteAsync(mech.Id);
                LoadMechanicsAsync();
            }
        }

        private void btnRefreshMechanics_Click(object sender, EventArgs e)
        {
            LoadMechanicsAsync();
        }

        //Repairs Tab
        private async void cmbCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            await LoadRepairsAsync();
        }

        private async void btnRefreshRepairs_Click(object sender, EventArgs e)
        {
            await LoadRepairsAsync();
        }

        private async void btnAddRepair_Click(object sender, EventArgs e)
        {
            if (cmbCars.SelectedValue is not int carId)
                return;

            using var dlg = new AddRepairForm(_recordService, _mechService, _carService);

            if (dlg.ShowDialog() == DialogResult.OK)
            { 
                await LoadRepairsAsync();
                await LoadCarsAsync();
            }
        }

        private async void btnDeleteRepair_Click(object sender, EventArgs e)
        {
            if (dgvRepairs.CurrentRow?.DataBoundItem is RepairViewModel vm)
            {
                await _recordService.DeleteAsync(vm.Id);
                await LoadRepairsAsync();
            }
        }

        private async void btnExportRepair_Click(object sender, EventArgs e)
        {
            if (dgvRepairs.CurrentRow?.DataBoundItem is RepairViewModel vm)
            {
                var bytes = await _pdfService.ExportServiceRecordAsync(vm.Id);
                using var dlg = new SaveFileDialog
                {
                    Filter = "PDF files (*.pdf)|*.pdf",
                    Title = "Save Service Record as PDF",
                    InitialDirectory =
                    Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                    FileName = $"ServiceRecord_{vm.Id}.pdf"
                };

                // 2) Show the dialog and only proceed if they click Save
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // 3) Write the file to the chosen path
                    File.WriteAllBytes(dlg.FileName, bytes);

                    // 4) Optional: notify the user
                    MessageBox.Show(
                        $"PDF saved to:\n{dlg.FileName}",
                        "Export Complete",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
        }
    }
}
