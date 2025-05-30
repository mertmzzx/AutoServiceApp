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

        public Form1(IMechanicService mechService, ICarService carService, IServiceRecordService recordService, IPdfExportService pdfService)
        {
            InitializeComponent();

            _mechService = mechService;
            _carService = carService;
            _recordService = recordService;
            _pdfService = pdfService;

            ConfigureRepairsGrid();
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

        private async Task LoadMechanics()
        {
            var list = await _mechService.GetAllAsync();
            dgvMechanics.DataSource = list;
        }

        private async Task LoadCars()
        {
            if ((await _carService.GetAllAsync()).Count == 0)
            {
                await _carService.AddAsync(new Car
                {
                    LicensePlate = "TEST123",
                    VIN = "1HGCM82633A004352",
                    Make = "TestMake",
                    Model = "TestModel",
                    Year = 2020
                });
            }
            var cars = await _carService.GetAllAsync();
            cmbCars.DisplayMember = "LicensePlate";
            cmbCars.ValueMember = "Id";
            cmbCars.DataSource = cars;
        }

        private async Task LoadRepairsAsync()
        {
            if (cmbCars.SelectedValue is not int carId) return;

            // 1) Get raw records
            var records = await _recordService.GetByCarIdAsync(carId);

            // 2) Project into RepairViewModel
            var vmList = records.Select(r => new RepairViewModel
            {
                Id = r.Id,
                Date = r.Date,
                Description = r.Description,
                Cost = r.Cost,
                CarPlate = r.Car.LicensePlate,
                MechanicName = r.Mechanic.Name
            })
            .ToList();

            // 3) Bind to DataGridView
            dgvRepairs.AutoGenerateColumns = false;
            dgvRepairs.DataSource = vmList;
        }
        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Do one then the other
            await LoadMechanics();
            await LoadCars();
        }

        // Mechanic Tab
        private void btnAddMechanic_Click(object sender, EventArgs e)
        {
            using var dlg = new AddMechanicForm(_mechService);
            if (dlg.ShowDialog() == DialogResult.OK)
                LoadMechanics();
        }

        private void btnEditMechanic_Click(object sender, EventArgs e)
        {
            if (dgvMechanics.CurrentRow?.DataBoundItem is Mechanic mech)
            {
                using var dlg = new AddMechanicForm(_mechService, mech);
                if (dlg.ShowDialog() == DialogResult.OK)
                    LoadMechanics();
            }
        }

        private async void btnDeleteMechanic_ClickAsync(object sender, EventArgs e)
        {
            if (dgvMechanics.CurrentRow?.DataBoundItem is Mechanic mech)
            {
                await _mechService.DeleteAsync(mech.Id);
                LoadMechanics();
            }
        }

        private void btnRefreshMechanics_Click(object sender, EventArgs e)
        {
            LoadMechanics();
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

        private void btnAddRepair_Click(object sender, EventArgs e)
        {
            if (cmbCars.SelectedValue is not int carId)
                return;

            using var dlg = new AddRepairForm(_recordService, _mechService, _carService);

            if (dlg.ShowDialog() == DialogResult.OK)
                _ = LoadRepairsAsync();
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
