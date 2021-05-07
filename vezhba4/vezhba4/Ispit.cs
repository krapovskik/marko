using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;

namespace vezhba4
{
    public partial class Ispit : Form
    {

        public Exam exam { get; set; }

        public Ispit()
        {
            InitializeComponent();
            comboBox1.DataSource = DateTimeFormatInfo.CurrentInfo.MonthNames;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            exam = new Exam(comboBox1.SelectedItem.ToString(),Convert.ToInt32(numericUpDown1.Value));
            DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
