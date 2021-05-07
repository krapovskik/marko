using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kosta_Krapovski_191126
{
    public partial class Додади_нов_ден : Form
    {
        public Day day { get; set; }

        public Додади_нов_ден()
        {
            InitializeComponent();
        }

        private void txtDen_Validating(object sender, CancelEventArgs e)
        {
            if (txtDen.Text.Trim().Length == 0 || Convert.ToInt32(txtDen.Text) <= 0 || Convert.ToInt32(txtDen.Text) > 31)
            {
                errorProvider1.SetError(txtDen, "Денот мора да биде цел број во распон од 1-31!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtDen, null);
                e.Cancel = false;
            }
        }

        


        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            day = new Day(txtDen.Text, cbMesec.SelectedItem.ToString(), Convert.ToInt32(txtZarazeni.Text), Convert.ToInt32(txtIzlecheni.Text));
            DialogResult = DialogResult.OK;
        }

        private void cbMesec_Validating(object sender, CancelEventArgs e)
        {
            if (cbMesec.SelectedIndex == -1)
            {
                errorProvider2.SetError(cbMesec, "Избери месец!");
                e.Cancel = true;
            }
            else
            {
                errorProvider2.SetError(cbMesec, null);
                e.Cancel = false;
            }
        }
    }
}
