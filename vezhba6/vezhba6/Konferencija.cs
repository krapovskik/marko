using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vezhba6
{
    public partial class Konferencija : Form
    {
        public Konf konferencija { get; set; }  
        
        public Konferencija()
        {
            InitializeComponent();
        }

        private void btnDodadi_Click(object sender, EventArgs e)
        {
            konferencija = new Konf((int)nudGodina.Value,txtIme.Text);
            DialogResult = DialogResult.OK;
        }

        private void btnOtkazhi_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
