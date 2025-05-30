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
    public partial class AddMechanicForm : Form
    {
        private readonly IMechanicService _mechanicService;
        private Mechanic? _mechanic;

        public AddMechanicForm(IMechanicService mechanicService, Mechanic? mechanic = null)
        {
            InitializeComponent();

            _mechanicService = mechanicService;
            _mechanic = mechanic;

            if (_mechanic != null)
            {
                // Edit mode
                txtName.Text = _mechanic.Name;
                txtPhone.Text = _mechanic.Phone;
                this.Text = "Edit Mechanic";
            }
            else
            {
                this.Text = "Add Mechanic";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name is required.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_mechanic == null)
            {
                // Create
                var newMechanic = new Mechanic
                {
                    Name = txtName.Text.Trim(),
                    Phone = txtPhone.Text.Trim()
                };
                await _mechanicService.AddAsync(newMechanic);
            }
            else
            {
                // Update
                _mechanic.Name = txtName.Text.Trim();
                _mechanic.Phone = txtPhone.Text.Trim();
                await _mechanicService.UpdateAsync(_mechanic);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private async void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
