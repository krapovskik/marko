using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vezhba5
{
    public partial class NovaMarka : Form
    {
        public CarMarka marka { get; set; }
        public NovaMarka()
        {
            InitializeComponent();
        }

        private void btnDodadi_Click(object sender, EventArgs e)
        {
            marka = new CarMarka(txtCode.Text, txtName.Text);
            DialogResult = DialogResult.OK;
        }

        private void btnOtkazhi_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
