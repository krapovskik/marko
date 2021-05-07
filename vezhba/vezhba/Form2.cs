using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace vezhba
{
    public partial class Form2 : Form
    {
        public Aerodrom MyAirport { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (txtName.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txtName, "Imeto e zadolzhitelno!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtName, null);
                e.Cancel = false;
            }
        }

        private void txtCity_Validating(object sender, CancelEventArgs e)
        {
            if (txtCity.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txtCity, "Gradot e zadolzhitelen!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtCity, null);
                e.Cancel = false;
            }
        }

        private void txtCode_Validating(object sender, CancelEventArgs e)
        {
            if (txtCode.Text.Trim().Length != 3)
            {
                errorProvider1.SetError(txtCode, "Kodot e zadolzhitelen!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtCode, null);
                e.Cancel = false;
            }
        }

        private void btnDodadi_Click(object sender, EventArgs e)
        {
            MyAirport  = new Aerodrom(txtName.Text,txtCity.Text,txtCode.Text);
            DialogResult = DialogResult.OK;
            
        }

        private void btnOtkazhi_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
