
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
            tabControl1.SuspendLayout();
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
            tabControl1.Controls.Add(tabMechanics);
            tabControl1.Controls.Add(tabRepairs);
            tabControl1.Controls.Add(tabHistory);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(870, 355);
            tabControl1.TabIndex = 0;
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
            tabMechanics.Size = new Size(862, 322);
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
            tabRepairs.Size = new Size(862, 322);
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
            tabHistory.Size = new Size(862, 322);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 355);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
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
        private TabPage tabMechanics;
        private TabPage tabRepairs;
        private Button btnRefreshMechanics;
        private Button btnDeleteMechanic;
        private Button btnEditMechanic;
        private Button btnAddMechanic;
        private DataGridView dgvMechanics;
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
    }
}
