using AutoService.Models;
using AutoService.Services;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using SkiaSharp;
using System.Diagnostics;



namespace AutoService
{
    public partial class Form1 : Form
    {
        private readonly IMechanicService _mechService;
        private readonly ICarService _carService;
        private readonly IServiceRecordService _recordService;
        private readonly IExportService _exportService;
        private List<Car> _allCars = new List<Car>();

        public Form1(IMechanicService mechService, ICarService carService, IServiceRecordService recordService, IExportService exportService)
        {
            InitializeComponent();

            btnApplyFilter.Click += async (_, __) =>
            {
                await LoadRevenueByMechanicChartAsync(
                    dtpFrom.Value.Date,
                    dtpTo.Value.Date.AddDays(1).AddTicks(-1) // include whole “To” day
                );
            };

            btnResetFilter.Click += async (_, __) =>
            {
                // 1) Restore your default window (e.g. last 30 days)
                dtpFrom.Value = DateTime.Today.AddMonths(-1);
                dtpTo.Value = DateTime.Today;

                // 2) Reload the chart with those defaults
                await LoadRevenueByMechanicChartAsync(dtpFrom.Value, dtpTo.Value);
            };


            _mechService = mechService;
            _carService = carService;
            _recordService = recordService;
            _exportService = exportService;

            ConfigureRepairsGrid();
            ConfigureHistoryGrid();
        }

        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            //Default date values
            dtpFrom.Value = DateTime.Today.AddMonths(-1);
            dtpTo.Value = DateTime.Today;

            await LoadTotalRevenueAsync();
            await LoadRevenueByMechanicChartAsync(dtpFrom.Value, dtpTo.Value);

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

        private void ConfigureHistoryGrid()
        {
            dgvHistory.Columns.Clear();
            dgvHistory.AutoGenerateColumns = false;
            dgvHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistory.MultiSelect = false;

            // Date
            dgvHistory.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(RepairViewModel.Date),
                HeaderText = "Date",
                DefaultCellStyle = { Format = "d" },
                Width = 80
            });
            // Description
            dgvHistory.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(RepairViewModel.Description),
                HeaderText = "Description",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            // Cost
            dgvHistory.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(RepairViewModel.Cost),
                HeaderText = "Cost",
                DefaultCellStyle = { Format = "C" },
                Width = 80
            });
            // Mechanic
            dgvHistory.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(RepairViewModel.MechanicName),
                HeaderText = "Mechanic",
                Width = 120
            });
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
                var bytes = await _exportService.ExportServiceRecordAsync(vm.Id);
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

        // Service Records Tab

        private async void btnSearchHistory_Click(object sender, EventArgs e)
        {
            dgvHistory.DataSource = null;

            var key = txtSearchCar.Text.Trim();
            if (string.IsNullOrEmpty(key))
            {
                MessageBox.Show("Please enter a license plate or VIN.");
                return;
            }

            // Try to find the car by plate or VIN in your cached list
            var car = _allCars
              .FirstOrDefault(c =>
                 c.LicensePlate.Equals(key, StringComparison.OrdinalIgnoreCase) ||
                 c.VIN.Equals(key, StringComparison.OrdinalIgnoreCase));

            if (car == null)
            {
                MessageBox.Show($"No car found matching “{key}”.");
                return;
            }

            // Load its history
            var records = await _recordService.GetByCarIdAsync(car.Id);

            // Project to the same RepairViewModel
            var vmList = records.Select(r => new RepairViewModel
            {
                Date = r.Date,
                Description = r.Description,
                Cost = r.Cost,
                MechanicName = r.Mechanic.Name
            })
            .ToList();

            dgvHistory.DataSource = vmList;
        }

        private async void btnExportRecordPdf_Click(object sender, EventArgs e)
        {
            if (dgvHistory.DataSource is not List<RepairViewModel> list || !list.Any())
            {
                MessageBox.Show("No records to export.");
                return;
            }

            // We need the car ID again: look it up by the search key
            var key = txtSearchCar.Text.Trim();
            var car = _allCars.FirstOrDefault(c =>
                c.LicensePlate.Equals(key, StringComparison.OrdinalIgnoreCase) ||
                c.VIN.Equals(key, StringComparison.OrdinalIgnoreCase));

            if (car == null) return; // guard

            var bytes = await _exportService.ExportServiceHistoryAsync(car.Id);
            if (bytes == null || bytes.Length == 0)
            {
                MessageBox.Show("Nothing to export.");
                return;
            }

            using var dlg = new SaveFileDialog
            {
                Filter = "PDF files (*.pdf)|*.pdf",
                Title = "Save Full Service History",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                FileName = $"{key}_History.pdf"
            };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(dlg.FileName, bytes);
                MessageBox.Show($"Exported to:\n{dlg.FileName}", "Done",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void btnExportRecordExcel_Click(object sender, EventArgs e)
        {
            var key = txtSearchCar.Text.Trim();
            if (string.IsNullOrEmpty(key))
            {
                MessageBox.Show("Please enter a license plate or VIN.",
                                "Export to Excel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Find the car from the in-memory list
            var car = _allCars.FirstOrDefault(c =>
                c.LicensePlate.Equals(key, StringComparison.OrdinalIgnoreCase) ||
                c.VIN.Equals(key, StringComparison.OrdinalIgnoreCase));

            if (car == null)
            {
                MessageBox.Show($"No car matches “{key}”.",
                                "Export to Excel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Call the service to build an Excel workbook of that car's full history
                var bytes = await _exportService.ExportServiceRecordExcelAsync(car.Id);
                if (bytes == null || bytes.Length == 0)
                {
                    MessageBox.Show("No history to export.",
                                    "Export to Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Show Save-As dialog
                using var dlg = new SaveFileDialog
                {
                    Filter = "Excel files (*.xlsx)|*.xlsx",
                    Title = "Save Service History to Excel",
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                    FileName = $"{key}_History.xlsx"
                };

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(dlg.FileName, bytes);
                    MessageBox.Show($"Excel saved to:\n{dlg.FileName}",
                                    "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Export failed:\n{ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Dashboard

        private async Task LoadTotalRevenueAsync()
        {
            // Suppose your service returns List<ServiceRecord>.
            // ServiceRecord has .Cost (decimal).
            var allRecords = await _recordService.GetAllAsync();
            decimal total = allRecords.Sum(r => r.Cost);
            lblTotalRevenueValue.Text = $"Total Revenue: {total:C}";
        }

        private async Task LoadRevenueByMechanicChartAsync(DateTime? from = null, DateTime? to = null)
        {
            // Get every record (with Mechanic & Car included)
            var allRecords = await _recordService.GetAllAsync();

            if (from.HasValue) allRecords = allRecords.Where(r => r.Date >= from.Value).ToList();
            if (to.HasValue) allRecords = allRecords.Where(r => r.Date <= to.Value).ToList();

            Debug.WriteLine($"Total service records fetched: {allRecords.Count}");
            // Discard any records that have no Mechanic, then group by r.Mechanic.Name
            var byMechanic = allRecords
                .Where(r => r.Mechanic != null)                    // skip null‐Mechanic
                .GroupBy(r => r.Mechanic.Name)
                .Select(g => new
                {
                    MechanicName = g.Key,
                    TotalRevenue = (double)g.Sum(r => r.Cost)
                })
                .OrderByDescending(x => x.TotalRevenue)
                .ToList();

            // If there are no valid mechanics, clear the chart
            if (byMechanic.Count == 0)
            {
                revenueChart.Series = Array.Empty<ISeries>();
                return;
            }

            // Extract labels & values
            var labels = byMechanic.Select(x => x.MechanicName).ToArray();
            var values = byMechanic.Select(x => x.TotalRevenue).ToArray();

            // Build the LiveCharts series
            var series = new ColumnSeries<double>
            {
                Values = values,
                Name = "Revenue"
                // → you can style Fill, Stroke, etc. here if you want
            };

            // Assign to the chart
            revenueChart.Series = new ISeries[] { series };

            // Configure the axes
            revenueChart.XAxes = new[]
            {
        new Axis
        {
            Labels          = labels,
            LabelsRotation  = 15,
            Name            = "Mechanic",
            NamePaint       = new SolidColorPaint(SKColor.Parse("000000"))
        }
    };

            revenueChart.YAxes = new[]
            {
        new Axis
        {
            Name      = "Revenue (лв.)",
            NamePaint = new SolidColorPaint(SKColor.Parse("000000"))
        }
    };
        }
    }
}
