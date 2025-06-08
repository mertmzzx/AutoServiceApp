using MaterialSkin.Controls;

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
            txtDescription = new MaterialTextBox();
            nudCost = new NumericUpDown();
            btnSave = new MaterialButton();
            btnCancel = new MaterialButton();
            cmbExistingCars = new ComboBox();
            lblExistingCar = new MaterialLabel();
            rbExistingCar = new MaterialRadioButton();
            rbNewCar = new MaterialRadioButton();
            panelNewCarFields = new Panel();
            lvlYear = new MaterialLabel();
            nudYear = new NumericUpDown();
            lblModel = new MaterialLabel();
            txtModel = new MaterialTextBox();
            lblMake = new MaterialLabel();
            txtMake = new MaterialTextBox();
            lblVIN = new MaterialLabel();
            txtVIN = new MaterialTextBox();
            lblLicensePlate = new MaterialLabel();
            txtLicensePlate = new MaterialTextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            lblMechanic = new MaterialLabel();
            lblCost = new MaterialLabel();
            lblDescription = new MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)nudCost).BeginInit();
            panelNewCarFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudYear).BeginInit();
            SuspendLayout();
            // 
            // cmbMechanics
            // 
            cmbMechanics.FormattingEnabled = true;
            cmbMechanics.Location = new Point(452, 119);
            cmbMechanics.Name = "cmbMechanics";
            cmbMechanics.Size = new Size(151, 28);
            cmbMechanics.TabIndex = 0;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(665, 188);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(193, 27);
            dtpDate.TabIndex = 1;
            // 
            // txtDescription
            // 
            txtDescription.AnimateReadOnly = false;
            txtDescription.BorderStyle = BorderStyle.None;
            txtDescription.Depth = 0;
            txtDescription.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDescription.LeadingIcon = null;
            txtDescription.Location = new Point(665, 123);
            txtDescription.MaxLength = 50;
            txtDescription.MouseState = MaterialSkin.MouseState.OUT;
            txtDescription.Multiline = false;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(350, 50);
            txtDescription.TabIndex = 2;
            txtDescription.Text = "";
            txtDescription.TrailingIcon = null;
            // 
            // nudCost
            // 
            nudCost.Location = new Point(452, 191);
            nudCost.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudCost.Name = "nudCost";
            nudCost.Size = new Size(151, 27);
            nudCost.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSave.Density = MaterialButton.MaterialButtonDensity.Default;
            btnSave.Depth = 0;
            btnSave.HighEmphasis = true;
            btnSave.Icon = null;
            btnSave.Location = new Point(711, 277);
            btnSave.Margin = new Padding(4, 6, 4, 6);
            btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            btnSave.Name = "btnSave";
            btnSave.NoAccentTextColor = Color.Empty;
            btnSave.Size = new Size(64, 36);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.Type = MaterialButton.MaterialButtonType.Contained;
            btnSave.UseAccentColor = false;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancel.Density = MaterialButton.MaterialButtonDensity.Default;
            btnCancel.Depth = 0;
            btnCancel.HighEmphasis = true;
            btnCancel.Icon = null;
            btnCancel.Location = new Point(892, 277);
            btnCancel.Margin = new Padding(4, 6, 4, 6);
            btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancel.Name = "btnCancel";
            btnCancel.NoAccentTextColor = Color.Empty;
            btnCancel.Size = new Size(77, 36);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.Type = MaterialButton.MaterialButtonType.Contained;
            btnCancel.UseAccentColor = false;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // cmbExistingCars
            // 
            cmbExistingCars.FormattingEnabled = true;
            cmbExistingCars.Location = new Point(40, 145);
            cmbExistingCars.Name = "cmbExistingCars";
            cmbExistingCars.Size = new Size(159, 28);
            cmbExistingCars.TabIndex = 6;
            // 
            // lblExistingCar
            // 
            lblExistingCar.AutoSize = true;
            lblExistingCar.Depth = 0;
            lblExistingCar.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblExistingCar.Location = new Point(40, 123);
            lblExistingCar.MouseState = MaterialSkin.MouseState.HOVER;
            lblExistingCar.Name = "lblExistingCar";
            lblExistingCar.Size = new Size(143, 19);
            lblExistingCar.TabIndex = 7;
            lblExistingCar.Text = "Choose existing car:";
            // 
            // rbExistingCar
            // 
            rbExistingCar.AutoSize = true;
            rbExistingCar.Depth = 0;
            rbExistingCar.Location = new Point(12, 79);
            rbExistingCar.Margin = new Padding(0);
            rbExistingCar.MouseLocation = new Point(-1, -1);
            rbExistingCar.MouseState = MaterialSkin.MouseState.HOVER;
            rbExistingCar.Name = "rbExistingCar";
            rbExistingCar.Ripple = true;
            rbExistingCar.Size = new Size(119, 37);
            rbExistingCar.TabIndex = 8;
            rbExistingCar.TabStop = true;
            rbExistingCar.Text = "Existing Car";
            rbExistingCar.UseVisualStyleBackColor = true;
            // 
            // rbNewCar
            // 
            rbNewCar.AutoSize = true;
            rbNewCar.Depth = 0;
            rbNewCar.Location = new Point(12, 191);
            rbNewCar.Margin = new Padding(0);
            rbNewCar.MouseLocation = new Point(-1, -1);
            rbNewCar.MouseState = MaterialSkin.MouseState.HOVER;
            rbNewCar.Name = "rbNewCar";
            rbNewCar.Ripple = true;
            rbNewCar.Size = new Size(94, 37);
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
            panelNewCarFields.Location = new Point(26, 231);
            panelNewCarFields.Name = "panelNewCarFields";
            panelNewCarFields.Size = new Size(383, 233);
            panelNewCarFields.TabIndex = 10;
            // 
            // lvlYear
            // 
            lvlYear.AutoSize = true;
            lvlYear.Depth = 0;
            lvlYear.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lvlYear.Location = new Point(220, 91);
            lvlYear.MouseState = MaterialSkin.MouseState.HOVER;
            lvlYear.Name = "lvlYear";
            lvlYear.Size = new Size(37, 19);
            lvlYear.TabIndex = 9;
            lvlYear.Text = "Year:";
            // 
            // nudYear
            // 
            nudYear.Location = new Point(220, 113);
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
            lblModel.Depth = 0;
            lblModel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblModel.Location = new Point(220, 7);
            lblModel.MouseState = MaterialSkin.MouseState.HOVER;
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(49, 19);
            lblModel.TabIndex = 7;
            lblModel.Text = "Model:";
            // 
            // txtModel
            // 
            txtModel.AnimateReadOnly = false;
            txtModel.BorderStyle = BorderStyle.None;
            txtModel.Depth = 0;
            txtModel.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtModel.LeadingIcon = null;
            txtModel.Location = new Point(220, 29);
            txtModel.MaxLength = 50;
            txtModel.MouseState = MaterialSkin.MouseState.OUT;
            txtModel.Multiline = false;
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(125, 50);
            txtModel.TabIndex = 6;
            txtModel.Text = "";
            txtModel.TrailingIcon = null;
            // 
            // lblMake
            // 
            lblMake.AutoSize = true;
            lblMake.Depth = 0;
            lblMake.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblMake.Location = new Point(14, 161);
            lblMake.MouseState = MaterialSkin.MouseState.HOVER;
            lblMake.Name = "lblMake";
            lblMake.Size = new Size(44, 19);
            lblMake.TabIndex = 5;
            lblMake.Text = "Make:";
            // 
            // txtMake
            // 
            txtMake.AnimateReadOnly = false;
            txtMake.BorderStyle = BorderStyle.None;
            txtMake.Depth = 0;
            txtMake.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtMake.LeadingIcon = null;
            txtMake.Location = new Point(14, 183);
            txtMake.MaxLength = 50;
            txtMake.MouseState = MaterialSkin.MouseState.OUT;
            txtMake.Multiline = false;
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(125, 50);
            txtMake.TabIndex = 4;
            txtMake.Text = "";
            txtMake.TrailingIcon = null;
            // 
            // lblVIN
            // 
            lblVIN.AutoSize = true;
            lblVIN.Depth = 0;
            lblVIN.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblVIN.Location = new Point(14, 82);
            lblVIN.MouseState = MaterialSkin.MouseState.HOVER;
            lblVIN.Name = "lblVIN";
            lblVIN.Size = new Size(30, 19);
            lblVIN.TabIndex = 3;
            lblVIN.Text = "VIN:";
            // 
            // txtVIN
            // 
            txtVIN.AnimateReadOnly = false;
            txtVIN.BorderStyle = BorderStyle.None;
            txtVIN.Depth = 0;
            txtVIN.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtVIN.LeadingIcon = null;
            txtVIN.Location = new Point(14, 104);
            txtVIN.MaxLength = 50;
            txtVIN.MouseState = MaterialSkin.MouseState.OUT;
            txtVIN.Multiline = false;
            txtVIN.Name = "txtVIN";
            txtVIN.Size = new Size(125, 50);
            txtVIN.TabIndex = 2;
            txtVIN.Text = "";
            txtVIN.TrailingIcon = null;
            // 
            // lblLicensePlate
            // 
            lblLicensePlate.AutoSize = true;
            lblLicensePlate.Depth = 0;
            lblLicensePlate.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblLicensePlate.Location = new Point(14, 7);
            lblLicensePlate.MouseState = MaterialSkin.MouseState.HOVER;
            lblLicensePlate.Name = "lblLicensePlate";
            lblLicensePlate.Size = new Size(99, 19);
            lblLicensePlate.TabIndex = 1;
            lblLicensePlate.Text = "License Plate:";
            // 
            // txtLicensePlate
            // 
            txtLicensePlate.AnimateReadOnly = false;
            txtLicensePlate.BorderStyle = BorderStyle.None;
            txtLicensePlate.Depth = 0;
            txtLicensePlate.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtLicensePlate.LeadingIcon = null;
            txtLicensePlate.Location = new Point(14, 30);
            txtLicensePlate.MaxLength = 50;
            txtLicensePlate.MouseState = MaterialSkin.MouseState.OUT;
            txtLicensePlate.Multiline = false;
            txtLicensePlate.Name = "txtLicensePlate";
            txtLicensePlate.Size = new Size(125, 50);
            txtLicensePlate.TabIndex = 0;
            txtLicensePlate.Text = "";
            txtLicensePlate.TrailingIcon = null;
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
            lblMechanic.Depth = 0;
            lblMechanic.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblMechanic.Location = new Point(452, 97);
            lblMechanic.MouseState = MaterialSkin.MouseState.HOVER;
            lblMechanic.Name = "lblMechanic";
            lblMechanic.Size = new Size(131, 19);
            lblMechanic.TabIndex = 12;
            lblMechanic.Text = "Choose mechanic:";
            // 
            // lblCost
            // 
            lblCost.AutoSize = true;
            lblCost.Depth = 0;
            lblCost.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblCost.Location = new Point(452, 166);
            lblCost.MouseState = MaterialSkin.MouseState.HOVER;
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(40, 19);
            lblCost.TabIndex = 13;
            lblCost.Text = "Price:";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Depth = 0;
            lblDescription.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblDescription.Location = new Point(665, 97);
            lblDescription.MouseState = MaterialSkin.MouseState.HOVER;
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(85, 19);
            lblDescription.TabIndex = 14;
            lblDescription.Text = "Description:";
            // 
            // AddRepairForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 478);
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
            Text = "Add Repair";
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
        private MaterialTextBox txtDescription;
        private NumericUpDown nudCost;
        private MaterialButton btnSave;
        private MaterialButton btnCancel;
        private ComboBox cmbExistingCars;
        private MaterialLabel lblExistingCar;
        private MaterialRadioButton rbExistingCar;
        private MaterialRadioButton rbNewCar;
        private Panel panelNewCarFields;
        private MaterialLabel lblLicensePlate;
        private MaterialTextBox txtLicensePlate;
        private MaterialLabel lblVIN;
        private MaterialTextBox txtVIN;
        private ContextMenuStrip contextMenuStrip1;
        private MaterialLabel lvlYear;
        private NumericUpDown nudYear;
        private MaterialLabel lblModel;
        private MaterialTextBox txtModel;
        private MaterialLabel lblMake;
        private MaterialTextBox txtMake;
        private MaterialLabel lblMechanic;
        private MaterialLabel lblCost;
        private MaterialLabel lblDescription;
    }
}