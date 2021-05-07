using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vezhba4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnIzbrishiIspit.Enabled = false;
        }

        private void btnDodadiIspit_Click(object sender, EventArgs e)
        {
            Ispit ispitche = new Ispit();
            if (ispitche.ShowDialog() == DialogResult.OK)
            {
                lblIspiti.Items.Add(ispitche.exam);
            }
        }

        private void btnIzbrishiIspit_Click(object sender, EventArgs e)
        {
            if (lblIspiti.SelectedIndex != -1)
            {
                lblIspiti.Items.Remove(lblIspiti.SelectedItem);
            }
        }

        private void updateZad()
        {
            Exam e = (Exam)lblIspiti.SelectedItem;
            if(e != null)
            {
                txtZad1.Text = e.zadachas[0].Opis;
                nudZad1.Value = e.zadachas[0].Poeni;
                txtZad2.Text = e.zadachas[1].Opis;
                nudZad2.Value = e.zadachas[1].Poeni;
            }
            else
            {
                txtZad1.Clear();
                nudZad1.Value = 0;
                txtZad2.Clear();
                nudZad2.Value = 0;
            }
        }

        private void lblIspiti_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnIzbrishiIspit.Enabled = true;
            if (lblIspiti.SelectedIndex == -1)
                btnIzbrishiIspit.Enabled = false;
            updateZad();

        }

        private void btnZad1_Click(object sender, EventArgs e)
        {
            if (lblIspiti.SelectedIndex != -1)
            {
                ((Exam)lblIspiti.SelectedItem).zadachas[0].Opis = txtZad1.Text;
                ((Exam)lblIspiti.SelectedItem).zadachas[0].Poeni = Convert.ToInt32( nudZad1.Value);
            }
        }

        private void btnZad2_Click(object sender, EventArgs e)
        {
            if (lblIspiti.SelectedIndex != -1)
            {
                ((Exam)lblIspiti.SelectedItem).zadachas[1].Opis = txtZad2.Text;
                ((Exam)lblIspiti.SelectedItem).zadachas[1].Poeni = Convert.ToInt32(nudZad2.Value);
            }
        }
    }
}
