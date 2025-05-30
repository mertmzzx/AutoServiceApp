namespace AutoService
{
    partial class AddRepairForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            cmbMechanics = new ComboBox();
            dtpDate = new DateTimePicker();
            txtDescription = new TextBox();
            nudCost = new NumericUpDown();
            btnSave = new Button();
            btnCancel = new Button();
            cmbExistingCars = new ComboBox();
            lblExistingCar = new Label();
            rbExistingCar = new RadioButton();
            rbNewCar = new RadioButton();
            panelNewCarFields = new Panel();
            lvlYear = new Label();
            nudYear = new NumericUpDown();
            lblModel = new Label();
            txtModel = new TextBox();
            lblMake = new Label();
            txtMake = new TextBox();
            lblVIN = new Label();
            txtVIN = new TextBox();
            lblLicensePlate = new Label();
            txtLicensePlate = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            lblMechanic = new Label();
            lblCost = new Label();
            lblDescription = new Label();
            ((System.ComponentModel.ISupportInitialize)nudCost).BeginInit();
            panelNewCarFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudYear).BeginInit();
            SuspendLayout();
            // 
            // cmbMechanics
            // 
            cmbMechanics.FormattingEnabled = true;
            cmbMechanics.Location = new Point(462, 57);
            cmbMechanics.Name = "cmbMechanics";
            cmbMechanics.Size = new Size(151, 28);
            cmbMechanics.TabIndex = 0;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(743, 185);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(193, 27);
            dtpDate.TabIndex = 1;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(670, 57);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(333, 112);
            txtDescription.TabIndex = 2;
            // 
            // nudCost
            // 
            nudCost.Location = new Point(462, 139);
            nudCost.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudCost.Name = "nudCost";
            nudCost.Size = new Size(151, 27);
            nudCost.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(583, 275);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(106, 44);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(783, 277);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(106, 42);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // cmbExistingCars
            // 
            cmbExistingCars.FormattingEnabled = true;
            cmbExistingCars.Location = new Point(12, 73);
            cmbExistingCars.Name = "cmbExistingCars";
            cmbExistingCars.Size = new Size(159, 28);
            cmbExistingCars.TabIndex = 6;
            // 
            // lblExistingCar
            // 
            lblExistingCar.AutoSize = true;
            lblExistingCar.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblExistingCar.Location = new Point(12, 45);
            lblExistingCar.Name = "lblExistingCar";
            lblExistingCar.Size = new Size(169, 25);
            lblExistingCar.TabIndex = 7;
            lblExistingCar.Text = "Choose existing car:";
            // 
            // rbExistingCar
            // 
            rbExistingCar.AutoSize = true;
            rbExistingCar.Location = new Point(12, 12);
            rbExistingCar.Name = "rbExistingCar";
            rbExistingCar.Size = new Size(107, 24);
            rbExistingCar.TabIndex = 8;
            rbExistingCar.TabStop = true;
            rbExistingCar.Text = "Existing Car";
            rbExistingCar.UseVisualStyleBackColor = true;
            // 
            // rbNewCar
            // 
            rbNewCar.AutoSize = true;
            rbNewCar.Location = new Point(12, 129);
            rbNewCar.Name = "rbNewCar";
            rbNewCar.Size = new Size(86, 24);
            rbNewCar.TabIndex = 9;
            rbNewCar.TabStop = true;
            rbNewCar.Text = "New Car";
            rbNewCar.UseVisualStyleBackColor = true;
            // 
            // panelNewCarFields
            // 
            panelNewCarFields.Controls.Add(lvlYear);
            panelNewCarFields.Controls.Add(nudYear);
            panelNewCarFields.Controls.Add(lblModel);
            panelNewCarFields.Controls.Add(txtModel);
            panelNewCarFields.Controls.Add(lblMake);
            panelNewCarFields.Controls.Add(txtMake);
            panelNewCarFields.Controls.Add(lblVIN);
            panelNewCarFields.Controls.Add(txtVIN);
            panelNewCarFields.Controls.Add(lblLicensePlate);
            panelNewCarFields.Controls.Add(txtLicensePlate);
            panelNewCarFields.Location = new Point(12, 159);
            panelNewCarFields.Name = "panelNewCarFields";
            panelNewCarFields.Size = new Size(383, 203);
            panelNewCarFields.TabIndex = 10;
            // 
            // lvlYear
            // 
            lvlYear.AutoSize = true;
            lvlYear.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lvlYear.Location = new Point(220, 76);
            lvlYear.Name = "lvlYear";
            lvlYear.Size = new Size(46, 23);
            lvlYear.TabIndex = 9;
            lvlYear.Text = "Year:";
            // 
            // nudYear
            // 
            nudYear.Location = new Point(220, 99);
            nudYear.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            nudYear.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            nudYear.Name = "nudYear";
            nudYear.Size = new Size(125, 27);
            nudYear.TabIndex = 8;
            nudYear.Value = new decimal(new int[] { 1900, 0, 0, 0 });
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblModel.Location = new Point(220, 7);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(62, 23);
            lblModel.TabIndex = 7;
            lblModel.Text = "Model:";
            // 
            // txtModel
            // 
            txtModel.Location = new Point(220, 30);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(125, 27);
            txtModel.TabIndex = 6;
            // 
            // lblMake
            // 
            lblMake.AutoSize = true;
            lblMake.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMake.Location = new Point(14, 147);
            lblMake.Name = "lblMake";
            lblMake.Size = new Size(55, 23);
            lblMake.TabIndex = 5;
            lblMake.Text = "Make:";
            // 
            // txtMake
            // 
            txtMake.Location = new Point(14, 170);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(125, 27);
            txtMake.TabIndex = 4;
            // 
            // lblVIN
            // 
            lblVIN.AutoSize = true;
            lblVIN.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVIN.Location = new Point(14, 76);
            lblVIN.Name = "lblVIN";
            lblVIN.Size = new Size(43, 23);
            lblVIN.TabIndex = 3;
            lblVIN.Text = "VIN:";
            // 
            // txtVIN
            // 
            txtVIN.Location = new Point(14, 99);
            txtVIN.Name = "txtVIN";
            txtVIN.Size = new Size(125, 27);
            txtVIN.TabIndex = 2;
            // 
            // lblLicensePlate
            // 
            lblLicensePlate.AutoSize = true;
            lblLicensePlate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLicensePlate.Location = new Point(14, 7);
            lblLicensePlate.Name = "lblLicensePlate";
            lblLicensePlate.Size = new Size(112, 23);
            lblLicensePlate.TabIndex = 1;
            lblLicensePlate.Text = "License Plate:";
            // 
            // txtLicensePlate
            // 
            txtLicensePlate.Location = new Point(14, 30);
            txtLicensePlate.Name = "txtLicensePlate";
            txtLicensePlate.Size = new Size(125, 27);
            txtLicensePlate.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // lblMechanic
            // 
            lblMechanic.AutoSize = true;
            lblMechanic.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMechanic.Location = new Point(462, 29);
            lblMechanic.Name = "lblMechanic";
            lblMechanic.Size = new Size(155, 25);
            lblMechanic.TabIndex = 12;
            lblMechanic.Text = "Choose mechanic:";
            // 
            // lblCost
            // 
            lblCost.AutoSize = true;
            lblCost.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCost.Location = new Point(462, 107);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(53, 25);
            lblCost.TabIndex = 13;
            lblCost.Text = "Price:";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescription.Location = new Point(670, 29);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(106, 25);
            lblDescription.TabIndex = 14;
            lblDescription.Text = "Description:";
            // 
            // AddRepairForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 374);
            Controls.Add(lblDescription);
            Controls.Add(lblCost);
            Controls.Add(lblMechanic);
            Controls.Add(panelNewCarFields);
            Controls.Add(rbNewCar);
            Controls.Add(rbExistingCar);
            Controls.Add(lblExistingCar);
            Controls.Add(cmbExistingCars);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(nudCost);
            Controls.Add(txtDescription);
            Controls.Add(dtpDate);
            Controls.Add(cmbMechanics);
            Name = "AddRepairForm";
            Text = "AddRepairForm";
            ((System.ComponentModel.ISupportInitialize)nudCost).EndInit();
            panelNewCarFields.ResumeLayout(false);
            panelNewCarFields.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudYear).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbMechanics;
        private DateTimePicker dtpDate;
        private TextBox txtDescription;
        private NumericUpDown nudCost;
        private Button btnSave;
        private Button btnCancel;
        private ComboBox cmbExistingCars;
        private Label lblExistingCar;
        private RadioButton rbExistingCar;
        private RadioButton rbNewCar;
        private Panel panelNewCarFields;
        private Label lblLicensePlate;
        private TextBox txtLicensePlate;
        private Label lblVIN;
        private TextBox txtVIN;
        private ContextMenuStrip contextMenuStrip1;
        private Label lvlYear;
        private NumericUpDown nudYear;
        private Label lblModel;
        private TextBox txtModel;
        private Label lblMake;
        private TextBox txtMake;
        private Label lblMechanic;
        private Label lblCost;
        private Label lblDescription;
    }
}