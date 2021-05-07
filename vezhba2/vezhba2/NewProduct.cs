using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vezhba2
{
    public partial class NewProduct : Form
    {
        public Product product { get; set; }

        public NewProduct()
        {
            InitializeComponent();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (txtIme.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                error.SetError(txtIme, "Vnesi ime!");
            }
            else
            {
                error.SetError(txtIme, null);
                e.Cancel = false;
            }
        }

        private void txtKategorija_Validating(object sender, CancelEventArgs e)
        {
            if (txtKategorija.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                error.SetError(txtKategorija, "Vnesi kategorija!");
            }
            else
            {
                error.SetError(txtKategorija, null);
                e.Cancel = false;
            }
        }

        private void txtCena_Validating(object sender, CancelEventArgs e)
        {
            if (txtCena.Text.Trim().Length == 0)
            {   
                error.SetError(txtCena, "Vnesi cena!");
                e.Cancel = true;
            }
            else
            {
                error.SetError(txtCena, null);
                e.Cancel = false;
            }
        }

        private void btnOtkazhi_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnDodadi_Click(object sender, EventArgs e)
        {
            product = new Product(txtIme.Text,txtKategorija.Text,Convert.ToInt32(txtCena.Text));
            DialogResult = DialogResult.OK;
        }
    }
}
