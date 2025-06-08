using MaterialSkin;
using MaterialSkin.Controls;

namespace AutoService
{
    partial class Form1 : MaterialForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            MaterialTabControl1 = new MaterialTabControl();
            tabDashboard = new TabPage();
            tblDashboard = new TableLayoutPanel();
            grpRevenueByMechanic = new MaterialCard();
            lblTotalRevenueValue = new Label();
            revenueChart = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            pnlAnalyticsPlaceholder = new Panel();
            btnResetFilter = new MaterialButton();
            lblDtpTo = new Label();
            lblDtpFrom = new Label();
            dtpFrom = new DateTimePicker();
            dtpTo = new DateTimePicker();
            btnApplyFilter = new MaterialButton();
            tabMechanics = new TabPage();
            btnRefreshMechanics = new MaterialButton();
            btnDeleteMechanic = new MaterialButton();
            btnEditMechanic = new MaterialButton();
            btnAddMechanic = new MaterialButton();
            dgvMechanics = new DataGridView();
            tabRepairs = new TabPage();
            btnExportRepair = new MaterialButton();
            btnRefreshRepairs = new MaterialButton();
            btnDeleteRepair = new MaterialButton();
            dgvRepairs = new DataGridView();
            btnAddRepair = new MaterialButton();
            cmbCars = new ComboBox();
            tabHistory = new TabPage();
            btnExportRecordExcel = new MaterialButton();
            btnExportRecordPdf = new MaterialButton();
            dgvHistory = new DataGridView();
            btnSearchHistory = new MaterialButton();
            txtSearchCar = new MaterialTextBox();
            lblSearchVinOrPlate = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            MaterialTabSelector1 = new MaterialTabSelector();
            MaterialTabControl1.SuspendLayout();
            tabDashboard.SuspendLayout();
            tblDashboard.SuspendLayout();
            grpRevenueByMechanic.SuspendLayout();
            pnlAnalyticsPlaceholder.SuspendLayout();
            tabMechanics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMechanics).BeginInit();
            tabRepairs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRepairs).BeginInit();
            tabHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            SuspendLayout();
            // 
            // MaterialTabControl1
            // 
            MaterialTabControl1.Controls.Add(tabDashboard);
            MaterialTabControl1.Controls.Add(tabMechanics);
            MaterialTabControl1.Controls.Add(tabRepairs);
            MaterialTabControl1.Controls.Add(tabHistory);
            MaterialTabControl1.Depth = 0;
            MaterialTabControl1.Dock = DockStyle.Fill;
            MaterialTabControl1.Location = new Point(3, 112);
            MaterialTabControl1.MouseState = MouseState.HOVER;
            MaterialTabControl1.Multiline = true;
            MaterialTabControl1.Name = "MaterialTabControl1";
            MaterialTabControl1.SelectedIndex = 0;
            MaterialTabControl1.Size = new Size(1263, 739);
            MaterialTabControl1.TabIndex = 0;
            // 
            // tabDashboard
            // 
            tabDashboard.Controls.Add(tblDashboard);
            tabDashboard.Location = new Point(4, 29);
            tabDashboard.Name = "tabDashboard";
            tabDashboard.Padding = new Padding(3);
            tabDashboard.Size = new Size(1255, 706);
            tabDashboard.TabIndex = 0;
            tabDashboard.Text = "Dashboard";
            // 
            // tblDashboard
            // 
            tblDashboard.ColumnCount = 2;
            tblDashboard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tblDashboard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tblDashboard.Controls.Add(grpRevenueByMechanic, 0, 1);
            tblDashboard.Controls.Add(pnlAnalyticsPlaceholder, 1, 1);
            tblDashboard.Dock = DockStyle.Fill;
            tblDashboard.Location = new Point(3, 3);
            tblDashboard.Name = "tblDashboard";
            tblDashboard.Padding = new Padding(10);
            tblDashboard.RowCount = 2;
            tblDashboard.RowStyles.Add(new RowStyle());
            tblDashboard.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblDashboard.Size = new Size(1249, 700);
            tblDashboard.TabIndex = 0;
            // 
            // grpRevenueByMechanic
            // 
            grpRevenueByMechanic.BackColor = Color.FromArgb(255, 255, 255);
            grpRevenueByMechanic.Controls.Add(lblTotalRevenueValue);
            grpRevenueByMechanic.Controls.Add(revenueChart);
            grpRevenueByMechanic.Depth = 0;
            grpRevenueByMechanic.Dock = DockStyle.Fill;
            grpRevenueByMechanic.Font = new Font("Segoe UI Semibold", 11F);
            grpRevenueByMechanic.ForeColor = Color.FromArgb(222, 0, 0, 0);
            grpRevenueByMechanic.Location = new Point(15, 15);
            grpRevenueByMechanic.Margin = new Padding(5);
            grpRevenueByMechanic.MouseState = MouseState.HOVER;
            grpRevenueByMechanic.Name = "grpRevenueByMechanic";
            grpRevenueByMechanic.Padding = new Padding(14);
            grpRevenueByMechanic.Size = new Size(727, 670);
            grpRevenueByMechanic.TabIndex = 1;
            grpRevenueByMechanic.Text = "Revenue by Mechanic";
            // 
            // lblTotalRevenueValue
            // 
            lblTotalRevenueValue.AutoSize = true;
            lblTotalRevenueValue.Dock = DockStyle.Top;
            lblTotalRevenueValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalRevenueValue.ForeColor = Color.DarkBlue;
            lblTotalRevenueValue.Location = new Point(14, 14);
            lblTotalRevenueValue.Name = "lblTotalRevenueValue";
            lblTotalRevenueValue.Size = new Size(333, 41);
            lblTotalRevenueValue.TabIndex = 0;
            lblTotalRevenueValue.Text = "Total Revenue: 0,00 лв";
            // 
            // revenueChart
            // 
            revenueChart.Dock = DockStyle.Fill;
            revenueChart.Location = new Point(14, 14);
            revenueChart.MatchAxesScreenDataRatio = false;
            revenueChart.Name = "revenueChart";
            revenueChart.Size = new Size(699, 642);
            revenueChart.TabIndex = 0;
            // 
            // pnlAnalyticsPlaceholder
            // 
            pnlAnalyticsPlaceholder.BackColor = Color.WhiteSmoke;
            pnlAnalyticsPlaceholder.Controls.Add(btnResetFilter);
            pnlAnalyticsPlaceholder.Controls.Add(lblDtpTo);
            pnlAnalyticsPlaceholder.Controls.Add(lblDtpFrom);
            pnlAnalyticsPlaceholder.Controls.Add(dtpFrom);
            pnlAnalyticsPlaceholder.Controls.Add(dtpTo);
            pnlAnalyticsPlaceholder.Controls.Add(btnApplyFilter);
            pnlAnalyticsPlaceholder.Dock = DockStyle.Fill;
            pnlAnalyticsPlaceholder.Location = new Point(752, 15);
            pnlAnalyticsPlaceholder.Margin = new Padding(5);
            pnlAnalyticsPlaceholder.Name = "pnlAnalyticsPlaceholder";
            pnlAnalyticsPlaceholder.Size = new Size(482, 670);
            pnlAnalyticsPlaceholder.TabIndex = 2;
            // 
            // btnResetFilter
            // 
            btnResetFilter.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnResetFilter.Density = MaterialButton.MaterialButtonDensity.Default;
            btnResetFilter.Depth = 0;
            btnResetFilter.HighEmphasis = true;
            btnResetFilter.Icon = null;
            btnResetFilter.Location = new Point(234, 154);
            btnResetFilter.Margin = new Padding(4, 6, 4, 6);
            btnResetFilter.MouseState = MouseState.HOVER;
            btnResetFilter.Name = "btnResetFilter";
            btnResetFilter.NoAccentTextColor = Color.Empty;
            btnResetFilter.Size = new Size(65, 36);
            btnResetFilter.TabIndex = 5;
            btnResetFilter.Text = "Reset";
            btnResetFilter.Type = MaterialButton.MaterialButtonType.Contained;
            btnResetFilter.UseAccentColor = false;
            btnResetFilter.UseVisualStyleBackColor = true;
            // 
            // lblDtpTo
            // 
            lblDtpTo.AutoSize = true;
            lblDtpTo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblDtpTo.ForeColor = Color.DarkBlue;
            lblDtpTo.Location = new Point(30, 43);
            lblDtpTo.Name = "lblDtpTo";
            lblDtpTo.Size = new Size(38, 28);
            lblDtpTo.TabIndex = 3;
            lblDtpTo.Text = "To:";
            // 
            // lblDtpFrom
            // 
            lblDtpFrom.AutoSize = true;
            lblDtpFrom.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDtpFrom.ForeColor = Color.DarkBlue;
            lblDtpFrom.Location = new Point(4, 3);
            lblDtpFrom.Name = "lblDtpFrom";
            lblDtpFrom.Size = new Size(64, 28);
            lblDtpFrom.TabIndex = 1;
            lblDtpFrom.Text = "From:";
            // 
            // dtpFrom
            // 
            dtpFrom.Location = new Point(74, 3);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(192, 27);
            dtpFrom.TabIndex = 0;
            // 
            // dtpTo
            // 
            dtpTo.Location = new Point(74, 45);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(192, 27);
            dtpTo.TabIndex = 2;
            // 
            // btnApplyFilter
            // 
            btnApplyFilter.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnApplyFilter.Density = MaterialButton.MaterialButtonDensity.Default;
            btnApplyFilter.Depth = 0;
            btnApplyFilter.HighEmphasis = true;
            btnApplyFilter.Icon = null;
            btnApplyFilter.Location = new Point(44, 154);
            btnApplyFilter.Margin = new Padding(4, 6, 4, 6);
            btnApplyFilter.MouseState = MouseState.HOVER;
            btnApplyFilter.Name = "btnApplyFilter";
            btnApplyFilter.NoAccentTextColor = Color.Empty;
            btnApplyFilter.Size = new Size(67, 36);
            btnApplyFilter.TabIndex = 4;
            btnApplyFilter.Text = "Apply";
            btnApplyFilter.Type = MaterialButton.MaterialButtonType.Contained;
            btnApplyFilter.UseAccentColor = false;
            btnApplyFilter.UseVisualStyleBackColor = true;
            // 
            // tabMechanics
            // 
            tabMechanics.Controls.Add(btnRefreshMechanics);
            tabMechanics.Controls.Add(btnDeleteMechanic);
            tabMechanics.Controls.Add(btnEditMechanic);
            tabMechanics.Controls.Add(btnAddMechanic);
            tabMechanics.Controls.Add(dgvMechanics);
            tabMechanics.Location = new Point(4, 29);
            tabMechanics.Name = "tabMechanics";
            tabMechanics.Padding = new Padding(3);
            tabMechanics.Size = new Size(1237, 659);
            tabMechanics.TabIndex = 0;
            tabMechanics.Text = "Mechanics";
            // 
            // btnRefreshMechanics
            // 
            btnRefreshMechanics.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRefreshMechanics.Density = MaterialButton.MaterialButtonDensity.Default;
            btnRefreshMechanics.Depth = 0;
            btnRefreshMechanics.HighEmphasis = true;
            btnRefreshMechanics.Icon = null;
            btnRefreshMechanics.Location = new Point(636, 176);
            btnRefreshMechanics.Margin = new Padding(4, 6, 4, 6);
            btnRefreshMechanics.MouseState = MouseState.HOVER;
            btnRefreshMechanics.Name = "btnRefreshMechanics";
            btnRefreshMechanics.NoAccentTextColor = Color.Empty;
            btnRefreshMechanics.Size = new Size(84, 36);
            btnRefreshMechanics.TabIndex = 4;
            btnRefreshMechanics.Text = "Refresh";
            btnRefreshMechanics.Type = MaterialButton.MaterialButtonType.Contained;
            btnRefreshMechanics.UseAccentColor = false;
            btnRefreshMechanics.UseVisualStyleBackColor = true;
            btnRefreshMechanics.Click += btnRefreshMechanics_Click;
            // 
            // btnDeleteMechanic
            // 
            btnDeleteMechanic.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDeleteMechanic.Density = MaterialButton.MaterialButtonDensity.Default;
            btnDeleteMechanic.Depth = 0;
            btnDeleteMechanic.HighEmphasis = true;
            btnDeleteMechanic.Icon = null;
            btnDeleteMechanic.Location = new Point(636, 118);
            btnDeleteMechanic.Margin = new Padding(4, 6, 4, 6);
            btnDeleteMechanic.MouseState = MouseState.HOVER;
            btnDeleteMechanic.Name = "btnDeleteMechanic";
            btnDeleteMechanic.NoAccentTextColor = Color.Empty;
            btnDeleteMechanic.Size = new Size(148, 36);
            btnDeleteMechanic.TabIndex = 3;
            btnDeleteMechanic.Text = "Delete Selected";
            btnDeleteMechanic.Type = MaterialButton.MaterialButtonType.Contained;
            btnDeleteMechanic.UseAccentColor = false;
            btnDeleteMechanic.UseVisualStyleBackColor = true;
            btnDeleteMechanic.Click += btnDeleteMechanic_ClickAsync;
            // 
            // btnEditMechanic
            // 
            btnEditMechanic.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditMechanic.Density = MaterialButton.MaterialButtonDensity.Default;
            btnEditMechanic.Depth = 0;
            btnEditMechanic.HighEmphasis = true;
            btnEditMechanic.Icon = null;
            btnEditMechanic.Location = new Point(636, 62);
            btnEditMechanic.Margin = new Padding(4, 6, 4, 6);
            btnEditMechanic.MouseState = MouseState.HOVER;
            btnEditMechanic.Name = "btnEditMechanic";
            btnEditMechanic.NoAccentTextColor = Color.Empty;
            btnEditMechanic.Size = new Size(127, 36);
            btnEditMechanic.TabIndex = 2;
            btnEditMechanic.Text = "Edit Selected";
            btnEditMechanic.Type = MaterialButton.MaterialButtonType.Contained;
            btnEditMechanic.UseAccentColor = false;
            btnEditMechanic.UseVisualStyleBackColor = true;
            btnEditMechanic.Click += btnEditMechanic_Click;
            // 
            // btnAddMechanic
            // 
            btnAddMechanic.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddMechanic.Density = MaterialButton.MaterialButtonDensity.Default;
            btnAddMechanic.Depth = 0;
            btnAddMechanic.HighEmphasis = true;
            btnAddMechanic.Icon = null;
            btnAddMechanic.Location = new Point(636, 3);
            btnAddMechanic.Margin = new Padding(4, 6, 4, 6);
            btnAddMechanic.MouseState = MouseState.HOVER;
            btnAddMechanic.Name = "btnAddMechanic";
            btnAddMechanic.NoAccentTextColor = Color.Empty;
            btnAddMechanic.Size = new Size(130, 36);
            btnAddMechanic.TabIndex = 1;
            btnAddMechanic.Text = "Add Mechanic";
            btnAddMechanic.Type = MaterialButton.MaterialButtonType.Contained;
            btnAddMechanic.UseAccentColor = false;
            btnAddMechanic.UseVisualStyleBackColor = true;
            btnAddMechanic.Click += btnAddMechanic_Click;
            // 
            // dgvMechanics
            // 
            dgvMechanics.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMechanics.Location = new Point(3, 3);
            dgvMechanics.Name = "dgvMechanics";
            dgvMechanics.RowHeadersWidth = 51;
            dgvMechanics.Size = new Size(611, 214);
            dgvMechanics.TabIndex = 0;
            // 
            // tabRepairs
            // 
            tabRepairs.Controls.Add(btnExportRepair);
            tabRepairs.Controls.Add(btnRefreshRepairs);
            tabRepairs.Controls.Add(btnDeleteRepair);
            tabRepairs.Controls.Add(dgvRepairs);
            tabRepairs.Controls.Add(btnAddRepair);
            tabRepairs.Controls.Add(cmbCars);
            tabRepairs.Location = new Point(4, 29);
            tabRepairs.Name = "tabRepairs";
            tabRepairs.Padding = new Padding(3);
            tabRepairs.Size = new Size(1237, 659);
            tabRepairs.TabIndex = 1;
            tabRepairs.Text = "Repairs";
            // 
            // btnExportRepair
            // 
            btnExportRepair.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExportRepair.Density = MaterialButton.MaterialButtonDensity.Default;
            btnExportRepair.Depth = 0;
            btnExportRepair.HighEmphasis = true;
            btnExportRepair.Icon = null;
            btnExportRepair.Location = new Point(684, 211);
            btnExportRepair.Margin = new Padding(4, 6, 4, 6);
            btnExportRepair.MouseState = MouseState.HOVER;
            btnExportRepair.Name = "btnExportRepair";
            btnExportRepair.NoAccentTextColor = Color.Empty;
            btnExportRepair.Size = new Size(137, 36);
            btnExportRepair.TabIndex = 5;
            btnExportRepair.Text = "Export Record";
            btnExportRepair.Type = MaterialButton.MaterialButtonType.Contained;
            btnExportRepair.UseAccentColor = false;
            btnExportRepair.UseVisualStyleBackColor = true;
            btnExportRepair.Click += btnExportRepair_Click;
            // 
            // btnRefreshRepairs
            // 
            btnRefreshRepairs.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRefreshRepairs.Density = MaterialButton.MaterialButtonDensity.Default;
            btnRefreshRepairs.Depth = 0;
            btnRefreshRepairs.HighEmphasis = true;
            btnRefreshRepairs.Icon = null;
            btnRefreshRepairs.Location = new Point(684, 155);
            btnRefreshRepairs.Margin = new Padding(4, 6, 4, 6);
            btnRefreshRepairs.MouseState = MouseState.HOVER;
            btnRefreshRepairs.Name = "btnRefreshRepairs";
            btnRefreshRepairs.NoAccentTextColor = Color.Empty;
            btnRefreshRepairs.Size = new Size(84, 36);
            btnRefreshRepairs.TabIndex = 4;
            btnRefreshRepairs.Text = "Refresh";
            btnRefreshRepairs.Type = MaterialButton.MaterialButtonType.Contained;
            btnRefreshRepairs.UseAccentColor = false;
            btnRefreshRepairs.UseVisualStyleBackColor = true;
            // 
            // btnDeleteRepair
            // 
            btnDeleteRepair.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDeleteRepair.Density = MaterialButton.MaterialButtonDensity.Default;
            btnDeleteRepair.Depth = 0;
            btnDeleteRepair.HighEmphasis = true;
            btnDeleteRepair.Icon = null;
            btnDeleteRepair.Location = new Point(684, 97);
            btnDeleteRepair.Margin = new Padding(4, 6, 4, 6);
            btnDeleteRepair.MouseState = MouseState.HOVER;
            btnDeleteRepair.Name = "btnDeleteRepair";
            btnDeleteRepair.NoAccentTextColor = Color.Empty;
            btnDeleteRepair.Size = new Size(127, 36);
            btnDeleteRepair.TabIndex = 3;
            btnDeleteRepair.Text = "Delete Repair";
            btnDeleteRepair.Type = MaterialButton.MaterialButtonType.Contained;
            btnDeleteRepair.UseAccentColor = false;
            btnDeleteRepair.UseVisualStyleBackColor = true;
            btnDeleteRepair.Click += btnDeleteRepair_Click;
            // 
            // dgvRepairs
            // 
            dgvRepairs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRepairs.Location = new Point(8, 40);
            dgvRepairs.Name = "dgvRepairs";
            dgvRepairs.RowHeadersWidth = 51;
            dgvRepairs.Size = new Size(650, 212);
            dgvRepairs.TabIndex = 2;
            // 
            // btnAddRepair
            // 
            btnAddRepair.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddRepair.Density = MaterialButton.MaterialButtonDensity.Default;
            btnAddRepair.Depth = 0;
            btnAddRepair.HighEmphasis = true;
            btnAddRepair.Icon = null;
            btnAddRepair.Location = new Point(684, 40);
            btnAddRepair.Margin = new Padding(4, 6, 4, 6);
            btnAddRepair.MouseState = MouseState.HOVER;
            btnAddRepair.Name = "btnAddRepair";
            btnAddRepair.NoAccentTextColor = Color.Empty;
            btnAddRepair.Size = new Size(104, 36);
            btnAddRepair.TabIndex = 1;
            btnAddRepair.Text = "Add Repair";
            btnAddRepair.Type = MaterialButton.MaterialButtonType.Contained;
            btnAddRepair.UseAccentColor = false;
            btnAddRepair.UseVisualStyleBackColor = true;
            btnAddRepair.Click += btnAddRepair_Click;
            // 
            // cmbCars
            // 
            cmbCars.FormattingEnabled = true;
            cmbCars.Location = new Point(8, 6);
            cmbCars.Name = "cmbCars";
            cmbCars.Size = new Size(178, 28);
            cmbCars.TabIndex = 0;
            // 
            // tabHistory
            // 
            tabHistory.Controls.Add(btnExportRecordExcel);
            tabHistory.Controls.Add(btnExportRecordPdf);
            tabHistory.Controls.Add(dgvHistory);
            tabHistory.Controls.Add(btnSearchHistory);
            tabHistory.Controls.Add(txtSearchCar);
            tabHistory.Controls.Add(lblSearchVinOrPlate);
            tabHistory.Location = new Point(4, 29);
            tabHistory.Name = "tabHistory";
            tabHistory.Padding = new Padding(3);
            tabHistory.Size = new Size(1237, 659);
            tabHistory.TabIndex = 2;
            tabHistory.Text = "Service History";
            // 
            // btnExportRecordExcel
            // 
            btnExportRecordExcel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExportRecordExcel.Density = MaterialButton.MaterialButtonDensity.Default;
            btnExportRecordExcel.Depth = 0;
            btnExportRecordExcel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExportRecordExcel.HighEmphasis = true;
            btnExportRecordExcel.Icon = null;
            btnExportRecordExcel.Location = new Point(359, 290);
            btnExportRecordExcel.Margin = new Padding(4, 6, 4, 6);
            btnExportRecordExcel.MouseState = MouseState.HOVER;
            btnExportRecordExcel.Name = "btnExportRecordExcel";
            btnExportRecordExcel.NoAccentTextColor = Color.Empty;
            btnExportRecordExcel.Size = new Size(216, 36);
            btnExportRecordExcel.TabIndex = 5;
            btnExportRecordExcel.Text = "Export Records to Excel";
            btnExportRecordExcel.Type = MaterialButton.MaterialButtonType.Contained;
            btnExportRecordExcel.UseAccentColor = false;
            btnExportRecordExcel.UseVisualStyleBackColor = true;
            btnExportRecordExcel.Click += btnExportRecordExcel_Click;
            // 
            // btnExportRecordPdf
            // 
            btnExportRecordPdf.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExportRecordPdf.Density = MaterialButton.MaterialButtonDensity.Default;
            btnExportRecordPdf.Depth = 0;
            btnExportRecordPdf.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExportRecordPdf.HighEmphasis = true;
            btnExportRecordPdf.Icon = null;
            btnExportRecordPdf.Location = new Point(18, 290);
            btnExportRecordPdf.Margin = new Padding(4, 6, 4, 6);
            btnExportRecordPdf.MouseState = MouseState.HOVER;
            btnExportRecordPdf.Name = "btnExportRecordPdf";
            btnExportRecordPdf.NoAccentTextColor = Color.Empty;
            btnExportRecordPdf.Size = new Size(199, 36);
            btnExportRecordPdf.TabIndex = 4;
            btnExportRecordPdf.Text = "Export Records to PDF";
            btnExportRecordPdf.Type = MaterialButton.MaterialButtonType.Contained;
            btnExportRecordPdf.UseAccentColor = false;
            btnExportRecordPdf.UseVisualStyleBackColor = true;
            btnExportRecordPdf.Click += btnExportRecordPdf_Click;
            // 
            // dgvHistory
            // 
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistory.Location = new Point(3, 70);
            dgvHistory.Name = "dgvHistory";
            dgvHistory.RowHeadersWidth = 51;
            dgvHistory.Size = new Size(596, 213);
            dgvHistory.TabIndex = 3;
            // 
            // btnSearchHistory
            // 
            btnSearchHistory.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSearchHistory.Density = MaterialButton.MaterialButtonDensity.Default;
            btnSearchHistory.Depth = 0;
            btnSearchHistory.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearchHistory.HighEmphasis = true;
            btnSearchHistory.Icon = null;
            btnSearchHistory.Location = new Point(480, 21);
            btnSearchHistory.Margin = new Padding(4, 6, 4, 6);
            btnSearchHistory.MouseState = MouseState.HOVER;
            btnSearchHistory.Name = "btnSearchHistory";
            btnSearchHistory.NoAccentTextColor = Color.Empty;
            btnSearchHistory.Size = new Size(78, 36);
            btnSearchHistory.TabIndex = 2;
            btnSearchHistory.Text = "Search";
            btnSearchHistory.Type = MaterialButton.MaterialButtonType.Contained;
            btnSearchHistory.UseAccentColor = false;
            btnSearchHistory.UseVisualStyleBackColor = true;
            btnSearchHistory.Click += btnSearchHistory_Click;
            // 
            // txtSearchCar
            // 
            txtSearchCar.AnimateReadOnly = false;
            txtSearchCar.BorderStyle = BorderStyle.None;
            txtSearchCar.Depth = 0;
            txtSearchCar.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSearchCar.LeadingIcon = null;
            txtSearchCar.Location = new Point(256, 14);
            txtSearchCar.MaxLength = 50;
            txtSearchCar.MouseState = MouseState.OUT;
            txtSearchCar.Multiline = false;
            txtSearchCar.Name = "txtSearchCar";
            txtSearchCar.Size = new Size(179, 50);
            txtSearchCar.TabIndex = 1;
            txtSearchCar.Text = "";
            txtSearchCar.TrailingIcon = null;
            // 
            // lblSearchVinOrPlate
            // 
            lblSearchVinOrPlate.AutoSize = true;
            lblSearchVinOrPlate.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearchVinOrPlate.ForeColor = Color.DarkBlue;
            lblSearchVinOrPlate.Location = new Point(6, 21);
            lblSearchVinOrPlate.Name = "lblSearchVinOrPlate";
            lblSearchVinOrPlate.Size = new Size(233, 31);
            lblSearchVinOrPlate.TabIndex = 0;
            lblSearchVinOrPlate.Text = "License Plate or VIN:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(3, 409);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(984, 8);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // MaterialTabSelector1
            // 
            MaterialTabSelector1.BaseTabControl = MaterialTabControl1;
            MaterialTabSelector1.CharacterCasing = MaterialTabSelector.CustomCharacterCasing.Normal;
            MaterialTabSelector1.Depth = 0;
            MaterialTabSelector1.Dock = DockStyle.Top;
            MaterialTabSelector1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            MaterialTabSelector1.Location = new Point(3, 64);
            MaterialTabSelector1.MouseState = MouseState.HOVER;
            MaterialTabSelector1.Name = "MaterialTabSelector1";
            MaterialTabSelector1.Size = new Size(1263, 48);
            MaterialTabSelector1.TabIndex = 0;
            MaterialTabSelector1.Text = "materialTabSelector1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1269, 854);
            Controls.Add(MaterialTabControl1);
            Controls.Add(MaterialTabSelector1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "AutoService";
            MaterialTabControl1.ResumeLayout(false);
            tabDashboard.ResumeLayout(false);
            tblDashboard.ResumeLayout(false);
            grpRevenueByMechanic.ResumeLayout(false);
            grpRevenueByMechanic.PerformLayout();
            pnlAnalyticsPlaceholder.ResumeLayout(false);
            pnlAnalyticsPlaceholder.PerformLayout();
            tabMechanics.ResumeLayout(false);
            tabMechanics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMechanics).EndInit();
            tabRepairs.ResumeLayout(false);
            tabRepairs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRepairs).EndInit();
            tabHistory.ResumeLayout(false);
            tabHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MaterialTabSelector MaterialTabSelector1;
        private MaterialTabControl MaterialTabControl1;
        private TabPage tabRepairs;
        private TabPage tabHistory;
        private ComboBox cmbCars;
        private MaterialButton btnExportRepair;
        private MaterialButton btnRefreshRepairs;
        private MaterialButton btnDeleteRepair;
        private DataGridView dgvRepairs;
        private MaterialButton btnAddRepair;
        private Label lblSearchVinOrPlate;
        private MaterialButton btnExportRecordPdf;
        private DataGridView dgvHistory;
        private MaterialButton btnSearchHistory;
        private MaterialTextBox txtSearchCar;
        private MaterialButton btnExportRecordExcel;
        private TabPage tabMechanics;
        private MaterialButton btnRefreshMechanics;
        private MaterialButton btnDeleteMechanic;
        private MaterialButton btnEditMechanic;
        private MaterialButton btnAddMechanic;
        private DataGridView dgvMechanics;
        private TabPage tabDashboard;
        private TableLayoutPanel tblDashboard;
        private TableLayoutPanel tableLayoutPanel1;
        private MaterialCard grpRevenueByMechanic;
        private Panel pnlAnalyticsPlaceholder;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart revenueChart;
        private Label lblDtpTo;
        private DateTimePicker dtpTo;
        private Label lblDtpFrom;
        private DateTimePicker dtpFrom;
        private MaterialButton btnApplyFilter;
        private MaterialButton btnResetFilter;
        private Label lblTotalRevenueValue;
    }
}
