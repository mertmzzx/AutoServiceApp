using AutoService.Models;
using AutoService.Services;
using MaterialSkin;
using MaterialSkin.Controls;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace AutoService
{
    public partial class AddMechanicForm : MaterialForm
    {
        private readonly IMechanicService _mechanicService;
        private Mechanic? _mechanic;
        private readonly ErrorProvider _errors = new ErrorProvider();

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

            _errors.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            txtName.Validating += TxtName_Validating;
            txtName.TextChanged += (s, e) => btnSave.Enabled = ValidateChildren();

            
            btnSave.Enabled = false;

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

        private void TxtName_Validating(object sender, CancelEventArgs e)
        {
            var mech = new Mechanic { Name = txtName.Text.Trim() };

            var ctx = new ValidationContext(mech) { MemberName = nameof(Mechanic.Name) };

            try
            {
                Validator.ValidateProperty(mech.Name, ctx);

                _errors.SetError(txtName, "");
            }
            catch (ValidationException ex)
            {
                _errors.SetError(txtName, ex.Message);
                e.Cancel = true;    
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            // this will trigger all Validating handlers
            if (!ValidateChildren())
            {
                MessageBox.Show(
                    "Please fix the highlighted errors before saving.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // now safe to build your Mechanic and call service
            var mech = new Mechanic
            {
                Name = txtName.Text.Trim(),
                Phone = txtPhone.Text.Trim() 
            };

            await _mechanicService.AddAsync(mech);
            DialogResult = DialogResult.OK;
        }


        private async void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
