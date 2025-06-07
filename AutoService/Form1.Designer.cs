namespace AutoService
{
    partial class Form1
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
            tabControl1 = new TabControl();
            tabDashboard = new TabPage();
            tblDashboard = new TableLayoutPanel();
            lblTotalRevenueValue = new Label();
            grpRevenueByMechanic = new GroupBox();
            revenueChart = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            pnlAnalyticsPlaceholder = new Panel();
            btnResetFilter = new Button();
            lblDtpTo = new Label();
            lblDtpFrom = new Label();
            dtpFrom = new DateTimePicker();
            dtpTo = new DateTimePicker();
            btnApplyFilter = new Button();
            tabMechanics = new TabPage();
            btnRefreshMechanics = new Button();
            btnDeleteMechanic = new Button();
            btnEditMechanic = new Button();
            btnAddMechanic = new Button();
            dgvMechanics = new DataGridView();
            tabRepairs = new TabPage();
            btnExportRepair = new Button();
            btnRefreshRepairs = new Button();
            btnDeleteRepair = new Button();
            dgvRepairs = new DataGridView();
            btnAddRepair = new Button();
            cmbCars = new ComboBox();
            tabHistory = new TabPage();
            btnExportRecordExcel = new Button();
            btnExportRecordPdf = new Button();
            dgvHistory = new DataGridView();
            btnSearchHistory = new Button();
            txtSearchCar = new TextBox();
            lblSearchVinOrPlate = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tabControl1.SuspendLayout();
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
            // tabControl1
            // 
            tabControl1.Controls.Add(tabDashboard);
            tabControl1.Controls.Add(tabMechanics);
            tabControl1.Controls.Add(tabRepairs);
            tabControl1.Controls.Add(tabHistory);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1034, 475);
            tabControl1.TabIndex = 0;
            // 
            // tabDashboard
            // 
            tabDashboard.Controls.Add(tblDashboard);
            tabDashboard.Location = new Point(4, 29);
            tabDashboard.Name = "tabDashboard";
            tabDashboard.Padding = new Padding(3);
            tabDashboard.Size = new Size(1026, 442);
            tabDashboard.TabIndex = 0;
            tabDashboard.Text = "Dashboard";
            tabDashboard.UseVisualStyleBackColor = true;
            // 
            // tblDashboard
            // 
            tblDashboard.ColumnCount = 2;
            tblDashboard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tblDashboard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tblDashboard.Controls.Add(lblTotalRevenueValue, 0, 0);
            tblDashboard.Controls.Add(grpRevenueByMechanic, 0, 1);
            tblDashboard.Controls.Add(pnlAnalyticsPlaceholder, 1, 1);
            tblDashboard.Dock = DockStyle.Fill;
            tblDashboard.Location = new Point(3, 3);
            tblDashboard.Name = "tblDashboard";
            tblDashboard.Padding = new Padding(10);
            tblDashboard.RowCount = 2;
            tblDashboard.RowStyles.Add(new RowStyle());
            tblDashboard.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblDashboard.Size = new Size(1020, 436);
            tblDashboard.TabIndex = 0;
            // 
            // lblTotalRevenueValue
            // 
            lblTotalRevenueValue.AutoSize = true;
            tblDashboard.SetColumnSpan(lblTotalRevenueValue, 2);
            lblTotalRevenueValue.Dock = DockStyle.Top;
            lblTotalRevenueValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTotalRevenueValue.ForeColor = Color.DarkBlue;
            lblTotalRevenueValue.Location = new Point(20, 20);
            lblTotalRevenueValue.Margin = new Padding(10, 10, 10, 20);
            lblTotalRevenueValue.Name = "lblTotalRevenueValue";
            lblTotalRevenueValue.Size = new Size(980, 41);
            lblTotalRevenueValue.TabIndex = 0;
            lblTotalRevenueValue.Text = "Total Revenue: 0,00 лв.";
            // 
            // grpRevenueByMechanic
            // 
            grpRevenueByMechanic.Controls.Add(revenueChart);
            grpRevenueByMechanic.Dock = DockStyle.Fill;
            grpRevenueByMechanic.Font = new Font("Segoe UI Semibold", 11F);
            grpRevenueByMechanic.Location = new Point(15, 86);
            grpRevenueByMechanic.Margin = new Padding(5);
            grpRevenueByMechanic.Name = "grpRevenueByMechanic";
            grpRevenueByMechanic.Size = new Size(590, 335);
            grpRevenueByMechanic.TabIndex = 1;
            grpRevenueByMechanic.TabStop = false;
            grpRevenueByMechanic.Text = "Revenue by Mechanic";
            // 
            // revenueChart
            // 
            revenueChart.Dock = DockStyle.Fill;
            revenueChart.Location = new Point(3, 28);
            revenueChart.MatchAxesScreenDataRatio = false;
            revenueChart.Name = "revenueChart";
            revenueChart.Size = new Size(584, 304);
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
            pnlAnalyticsPlaceholder.Location = new Point(615, 86);
            pnlAnalyticsPlaceholder.Margin = new Padding(5);
            pnlAnalyticsPlaceholder.Name = "pnlAnalyticsPlaceholder";
            pnlAnalyticsPlaceholder.Size = new Size(390, 335);
            pnlAnalyticsPlaceholder.TabIndex = 2;
            // 
            // btnResetFilter
            // 
            btnResetFilter.Location = new Point(234, 154);
            btnResetFilter.Name = "btnResetFilter";
            btnResetFilter.Size = new Size(94, 32);
            btnResetFilter.TabIndex = 5;
            btnResetFilter.Text = "Reset";
            btnResetFilter.UseVisualStyleBackColor = true;
            // 
            // lblDtpTo
            // 
            lblDtpTo.AutoSize = true;
            lblDtpTo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            btnApplyFilter.Location = new Point(44, 154);
            btnApplyFilter.Name = "btnApplyFilter";
            btnApplyFilter.Size = new Size(94, 32);
            btnApplyFilter.TabIndex = 4;
            btnApplyFilter.Text = "Apply";
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
            tabMechanics.Size = new Size(1026, 442);
            tabMechanics.TabIndex = 0;
            tabMechanics.Text = "Mechanics";
            tabMechanics.UseVisualStyleBackColor = true;
            // 
            // btnRefreshMechanics
            // 
            btnRefreshMechanics.Location = new Point(636, 176);
            btnRefreshMechanics.Name = "btnRefreshMechanics";
            btnRefreshMechanics.Size = new Size(125, 41);
            btnRefreshMechanics.TabIndex = 4;
            btnRefreshMechanics.Text = "Refresh";
            btnRefreshMechanics.UseVisualStyleBackColor = true;
            btnRefreshMechanics.Click += btnRefreshMechanics_Click;
            // 
            // btnDeleteMechanic
            // 
            btnDeleteMechanic.Location = new Point(636, 118);
            btnDeleteMechanic.Name = "btnDeleteMechanic";
            btnDeleteMechanic.Size = new Size(125, 41);
            btnDeleteMechanic.TabIndex = 3;
            btnDeleteMechanic.Text = "Delete Selected";
            btnDeleteMechanic.UseVisualStyleBackColor = true;
            btnDeleteMechanic.Click += btnDeleteMechanic_ClickAsync;
            // 
            // btnEditMechanic
            // 
            btnEditMechanic.Location = new Point(636, 62);
            btnEditMechanic.Name = "btnEditMechanic";
            btnEditMechanic.Size = new Size(125, 41);
            btnEditMechanic.TabIndex = 2;
            btnEditMechanic.Text = "Edit Selected";
            btnEditMechanic.UseVisualStyleBackColor = true;
            btnEditMechanic.Click += btnEditMechanic_Click;
            // 
            // btnAddMechanic
            // 
            btnAddMechanic.Location = new Point(636, 3);
            btnAddMechanic.Name = "btnAddMechanic";
            btnAddMechanic.Size = new Size(125, 41);
            btnAddMechanic.TabIndex = 1;
            btnAddMechanic.Text = "Add Mechanic";
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
            tabRepairs.Size = new Size(1026, 442);
            tabRepairs.TabIndex = 1;
            tabRepairs.Text = "Repairs";
            tabRepairs.UseVisualStyleBackColor = true;
            // 
            // btnExportRepair
            // 
            btnExportRepair.Location = new Point(684, 211);
            btnExportRepair.Name = "btnExportRepair";
            btnExportRepair.Size = new Size(125, 41);
            btnExportRepair.TabIndex = 5;
            btnExportRepair.Text = "Export Record";
            btnExportRepair.UseVisualStyleBackColor = true;
            btnExportRepair.Click += btnExportRepair_Click;
            // 
            // btnRefreshRepairs
            // 
            btnRefreshRepairs.Location = new Point(684, 155);
            btnRefreshRepairs.Name = "btnRefreshRepairs";
            btnRefreshRepairs.Size = new Size(125, 41);
            btnRefreshRepairs.TabIndex = 4;
            btnRefreshRepairs.Text = "Refresh";
            btnRefreshRepairs.UseVisualStyleBackColor = true;
            // 
            // btnDeleteRepair
            // 
            btnDeleteRepair.Location = new Point(684, 97);
            btnDeleteRepair.Name = "btnDeleteRepair";
            btnDeleteRepair.Size = new Size(125, 41);
            btnDeleteRepair.TabIndex = 3;
            btnDeleteRepair.Text = "Delete Repair";
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
            btnAddRepair.Location = new Point(684, 40);
            btnAddRepair.Name = "btnAddRepair";
            btnAddRepair.Size = new Size(125, 41);
            btnAddRepair.TabIndex = 1;
            btnAddRepair.Text = "Add Repair";
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
            tabHistory.Size = new Size(1026, 442);
            tabHistory.TabIndex = 2;
            tabHistory.Text = "Service History";
            tabHistory.UseVisualStyleBackColor = true;
            // 
            // btnExportRecordExcel
            // 
            btnExportRecordExcel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExportRecordExcel.Location = new Point(353, 267);
            btnExportRecordExcel.Name = "btnExportRecordExcel";
            btnExportRecordExcel.Size = new Size(223, 36);
            btnExportRecordExcel.TabIndex = 5;
            btnExportRecordExcel.Text = "Export Records to Excel";
            btnExportRecordExcel.UseVisualStyleBackColor = true;
            btnExportRecordExcel.Click += btnExportRecordExcel_Click;
            // 
            // btnExportRecordPdf
            // 
            btnExportRecordPdf.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExportRecordPdf.Location = new Point(19, 267);
            btnExportRecordPdf.Name = "btnExportRecordPdf";
            btnExportRecordPdf.Size = new Size(223, 36);
            btnExportRecordPdf.TabIndex = 4;
            btnExportRecordPdf.Text = "Export Records to PDF";
            btnExportRecordPdf.UseVisualStyleBackColor = true;
            btnExportRecordPdf.Click += btnExportRecordPdf_Click;
            // 
            // dgvHistory
            // 
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistory.Location = new Point(6, 48);
            dgvHistory.Name = "dgvHistory";
            dgvHistory.RowHeadersWidth = 51;
            dgvHistory.Size = new Size(596, 213);
            dgvHistory.TabIndex = 3;
            // 
            // btnSearchHistory
            // 
            btnSearchHistory.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearchHistory.Location = new Point(497, 10);
            btnSearchHistory.Name = "btnSearchHistory";
            btnSearchHistory.Size = new Size(105, 36);
            btnSearchHistory.TabIndex = 2;
            btnSearchHistory.Text = "Search";
            btnSearchHistory.UseVisualStyleBackColor = true;
            btnSearchHistory.Click += btnSearchHistory_Click;
            // 
            // txtSearchCar
            // 
            txtSearchCar.Location = new Point(174, 14);
            txtSearchCar.Name = "txtSearchCar";
            txtSearchCar.Size = new Size(150, 27);
            txtSearchCar.TabIndex = 1;
            // 
            // lblSearchVinOrPlate
            // 
            lblSearchVinOrPlate.AutoSize = true;
            lblSearchVinOrPlate.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearchVinOrPlate.Location = new Point(6, 14);
            lblSearchVinOrPlate.Name = "lblSearchVinOrPlate";
            lblSearchVinOrPlate.Size = new Size(171, 25);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 475);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabDashboard.ResumeLayout(false);
            tblDashboard.ResumeLayout(false);
            tblDashboard.PerformLayout();
            grpRevenueByMechanic.ResumeLayout(false);
            pnlAnalyticsPlaceholder.ResumeLayout(false);
            pnlAnalyticsPlaceholder.PerformLayout();
            tabMechanics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMechanics).EndInit();
            tabRepairs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRepairs).EndInit();
            tabHistory.ResumeLayout(false);
            tabHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabRepairs;
        private TabPage tabHistory;
        private ComboBox cmbCars;
        private Button btnExportRepair;
        private Button btnRefreshRepairs;
        private Button btnDeleteRepair;
        private DataGridView dgvRepairs;
        private Button btnAddRepair;
        private Label lblSearchVinOrPlate;
        private Button btnExportRecordPdf;
        private DataGridView dgvHistory;
        private Button btnSearchHistory;
        private TextBox txtSearchCar;
        private Button btnExportRecordExcel;
        private TabPage tabMechanics;
        private Button btnRefreshMechanics;
        private Button btnDeleteMechanic;
        private Button btnEditMechanic;
        private Button btnAddMechanic;
        private DataGridView dgvMechanics;
        private TabPage tabDashboard;
        private TableLayoutPanel tblDashboard;
        private Label lblTotalRevenueValue;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox grpRevenueByMechanic;
        private Panel pnlAnalyticsPlaceholder;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart revenueChart;
        private Label lblDtpTo;
        private DateTimePicker dtpTo;
        private Label lblDtpFrom;
        private DateTimePicker dtpFrom;
        private Button btnApplyFilter;
        private Button btnResetFilter;
    }
}
