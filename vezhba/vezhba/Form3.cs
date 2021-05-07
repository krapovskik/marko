using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vezhba
{
    public partial class Form3 : Form
    {
        public Destination MyDestination { get; set; }

        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(textBox1, "Gradot e zadolzhitelen!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textBox1, null);
                e.Cancel = false;
            }
        }

        private void txtRastojanie_Validating(object sender, CancelEventArgs e)
        {
            if (txtRastojanie.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txtRastojanie, "Rastojanieto e zadolzhitelno!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtRastojanie, null);
                e.Cancel = false;
            }
        }

        private void txtCena_Validating(object sender, CancelEventArgs e)
        {
            if (txtCena.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txtCena, "Cenata e zadolzhitelna!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtCena, null);
                e.Cancel = false;
            }
        }

        private void btnDodadi_Click(object sender, EventArgs e)
        {
            MyDestination = new Destination(textBox1.Text, Convert.ToInt32(txtRastojanie.Text), Convert.ToInt32(txtCena.Text));
            DialogResult = DialogResult.OK;
        }

        private void btnOtkazhi_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
