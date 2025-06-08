using AutoService.Models;
using AutoService.Services;
using MaterialSkin;
using MaterialSkin.Controls;

namespace AutoService
{
    public partial class AddMechanicForm : MaterialForm
    {
        private readonly IMechanicService _mechanicService;
        private Mechanic? _mechanic;

        public AddMechanicForm(IMechanicService mechanicService, Mechanic? mechanic = null)
        {
            InitializeComponent();

            var mgr = MaterialSkinManager.Instance;
            mgr.AddFormToManage(this);
            mgr.Theme = MaterialSkinManager.Themes.LIGHT;  
            mgr.ColorScheme = new ColorScheme(
                Primary.Blue600, Primary.Blue900,
                Primary.Blue100, Accent.LightBlue200,
                TextShade.WHITE
            );

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
