using AutoService.Models;
using AutoService.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoService
{
    public partial class AddRepairForm : Form
    {
        private readonly IServiceRecordService _recordSvc;
        private readonly IMechanicService _mechSvc;
        private readonly ICarService _carSvc;
        private readonly int _carId;

        public AddRepairForm(
            IServiceRecordService recordSvc,
            IMechanicService mechSvc,
            ICarService carSvc,
            int? carId = null)
        {
            InitializeComponent();
            _recordSvc = recordSvc;
            _mechSvc = mechSvc;
            _carSvc = carSvc;

            // Dissapering effect
            rbNewCar.CheckedChanged += rbNewCar_CheckedChanged;
            rbExistingCar.CheckedChanged += rbNewCar_CheckedChanged;
            rbExistingCar.Checked = true;
            rbNewCar_CheckedChanged(rbNewCar, EventArgs.Empty);

            LoadMechanics();
            LoadCars(carId);
            dtpDate.Value = DateTime.Today;
        }

        private async void LoadMechanics()
        {
            var mechs = await _mechSvc.GetAllAsync();
            cmbMechanics.DisplayMember = "Name";
            cmbMechanics.ValueMember = "Id";
            cmbMechanics.DataSource = mechs;
        }

        private async void LoadCars(int? preselectId)
        {
            var cars = await _carSvc.GetAllAsync();
            cmbExistingCars.DisplayMember = "LicensePlate";
            cmbExistingCars.ValueMember = "Id";
            cmbExistingCars.DataSource = cars;
            if (preselectId.HasValue)
                cmbExistingCars.SelectedValue = preselectId.Value;
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
            int carId;

            if (rbNewCar.Checked)
            {
                // 1) Create the new car
                var newCar = new Car
                {
                    LicensePlate = txtLicensePlate.Text.Trim(),
                    VIN = txtVIN.Text.Trim(),
                    Make = txtMake.Text.Trim(),
                    Model = txtModel.Text.Trim(),
                    Year = (int)nudYear.Value
                };
                await _carSvc.AddAsync(newCar);
                carId = newCar.Id;
            }
            else
            {
                // 2) Use selected existing car
                if (cmbExistingCars.SelectedValue is not int existingId)
                {
                    MessageBox.Show("Please select a car or choose New Car.");
                    return;
                }
                carId = existingId;
            }

            // 3) Now create the service record for that carId
            if (cmbMechanics.SelectedValue is not int mechId)
            {
                MessageBox.Show("Select a mechanic.");
                return;
            }

            var record = new ServiceRecord
            {
                CarId = carId,
                MechanicId = mechId,
                Date = dtpDate.Value,
                Description = txtDescription.Text.Trim(),
                Cost = nudCost.Value
            };
            await _recordSvc.AddAsync(record);

            DialogResult = DialogResult.OK;
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
