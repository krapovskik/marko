using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vezhba3
{
    public partial class Form2 : Form
    {
        public Vozach vozach { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if (txtIme.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txtIme, "Vnesi ime!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtIme, null);
                e.Cancel = false;
            }
        }

        private void nudVozrast_Validating(object sender, CancelEventArgs e)
        {
            if (nudVozrast.Value < 18)
            {
                errorProvider1.SetError(nudVozrast, "Vnesi godini pogolemi od 18!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(nudVozrast, null);
                e.Cancel = false;
            }
        }

        private void btnOtkazhi_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnDodadi_Click(object sender, EventArgs e)
        {
            if (cbPrvVozach.Checked)
            {
                vozach = new Vozach(txtIme.Text,Convert.ToInt32(nudVozrast.Value));
                vozach.First = true;
            }
            else
            {
                vozach = new Vozach(txtIme.Text, Convert.ToInt32(nudVozrast.Value));
            }
            DialogResult = DialogResult.OK;

        }
    }
}
