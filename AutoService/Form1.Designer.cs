
namespace AutoService
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
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
            tabControl1.SuspendLayout();
            tabMechanics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMechanics).BeginInit();
            tabRepairs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRepairs).BeginInit();
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
            tabControl1.Size = new Size(952, 486);
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
            tabMechanics.Size = new Size(944, 453);
            tabMechanics.TabIndex = 0;
            tabMechanics.Text = "Mechanics";
            tabMechanics.UseVisualStyleBackColor = true;
            // 
            // btnRefreshMechanics
            // 
            btnRefreshMechanics.Location = new Point(489, 212);
            btnRefreshMechanics.Name = "btnRefreshMechanics";
            btnRefreshMechanics.Size = new Size(125, 41);
            btnRefreshMechanics.TabIndex = 4;
            btnRefreshMechanics.Text = "Refresh";
            btnRefreshMechanics.UseVisualStyleBackColor = true;
            btnRefreshMechanics.Click += btnRefreshMechanics_Click;
            // 
            // btnDeleteMechanic
            // 
            btnDeleteMechanic.Location = new Point(336, 212);
            btnDeleteMechanic.Name = "btnDeleteMechanic";
            btnDeleteMechanic.Size = new Size(125, 41);
            btnDeleteMechanic.TabIndex = 3;
            btnDeleteMechanic.Text = "Delete Selected";
            btnDeleteMechanic.UseVisualStyleBackColor = true;
            btnDeleteMechanic.Click += btnDeleteMechanic_ClickAsync;
            // 
            // btnEditMechanic
            // 
            btnEditMechanic.Location = new Point(173, 212);
            btnEditMechanic.Name = "btnEditMechanic";
            btnEditMechanic.Size = new Size(125, 41);
            btnEditMechanic.TabIndex = 2;
            btnEditMechanic.Text = "Edit Selected";
            btnEditMechanic.UseVisualStyleBackColor = true;
            btnEditMechanic.Click += btnEditMechanic_Click;
            // 
            // btnAddMechanic
            // 
            btnAddMechanic.Location = new Point(3, 212);
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
            dgvMechanics.Dock = DockStyle.Top;
            dgvMechanics.Location = new Point(3, 3);
            dgvMechanics.Name = "dgvMechanics";
            dgvMechanics.RowHeadersWidth = 51;
            dgvMechanics.Size = new Size(938, 188);
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
            tabRepairs.Size = new Size(944, 453);
            tabRepairs.TabIndex = 1;
            tabRepairs.Text = "Repairs";
            tabRepairs.UseVisualStyleBackColor = true;
            // 
            // btnExportRepair
            // 
            btnExportRepair.Location = new Point(720, 200);
            btnExportRepair.Name = "btnExportRepair";
            btnExportRepair.Size = new Size(126, 28);
            btnExportRepair.TabIndex = 5;
            btnExportRepair.Text = "Export Record";
            btnExportRepair.UseVisualStyleBackColor = true;
            btnExportRepair.Click += btnExportRepair_Click;
            // 
            // btnRefreshRepairs
            // 
            btnRefreshRepairs.Location = new Point(720, 143);
            btnRefreshRepairs.Name = "btnRefreshRepairs";
            btnRefreshRepairs.Size = new Size(126, 28);
            btnRefreshRepairs.TabIndex = 4;
            btnRefreshRepairs.Text = "Refresh";
            btnRefreshRepairs.UseVisualStyleBackColor = true;
            // 
            // btnDeleteRepair
            // 
            btnDeleteRepair.Location = new Point(720, 88);
            btnDeleteRepair.Name = "btnDeleteRepair";
            btnDeleteRepair.Size = new Size(126, 28);
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
            dgvRepairs.Size = new Size(658, 188);
            dgvRepairs.TabIndex = 2;
            // 
            // btnAddRepair
            // 
            btnAddRepair.Location = new Point(720, 40);
            btnAddRepair.Name = "btnAddRepair";
            btnAddRepair.Size = new Size(126, 28);
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
            tabHistory.Location = new Point(4, 29);
            tabHistory.Name = "tabHistory";
            tabHistory.Padding = new Padding(3);
            tabHistory.Size = new Size(944, 453);
            tabHistory.TabIndex = 2;
            tabHistory.Text = "Service History";
            tabHistory.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 486);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabMechanics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMechanics).EndInit();
            tabRepairs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRepairs).EndInit();
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
    }
}
