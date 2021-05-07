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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnIzbrishiDen.Enabled = false;
            txtMaxZarazeni.Enabled = false;
        }

        private void btnDodadiDen_Click(object sender, EventArgs e)
        {
            Додади_нов_ден newDay = new Додади_нов_ден();
            if(newDay.ShowDialog() == DialogResult.OK)
            {
                if(lbDenovi.Items.OfType<Day>().Contains(newDay.day))
                {
                    MessageBox.Show("Соодветниот ден постови во листата");
                }
                else
                {
                    newDay.day.Zakluchen = false;
                    lbDenovi.Items.Add(newDay.day);
                    checkMaxZarazeni();
                }
            }
        }

        private void btnIzbrishiDen_Click(object sender, EventArgs e)
        {
            if (lbDenovi.SelectedIndex != -1)
            {
                if(MessageBox.Show("Дали сакате да го избришете овој датум?","Потврда",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lbDenovi.Items.Remove(lbDenovi.SelectedItem);
                    checkMaxZarazeni();
                }
            }
        }

        private void lbDenovi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Day tempDay = (Day)lbDenovi.SelectedItem;
            if (tempDay != null)
            {
                txtNLica.Text = tempDay.Zarazeni.ToString();
                txtILica.Text = tempDay.Izlecheni.ToString();
                cbZakluchiDen.Checked = tempDay.Zakluchen;
                btnIzbrishiDen.Enabled = true;
                checkMaxZarazeni();

            }
            else
            {
                txtNLica.Clear();
                txtILica.Clear();
                txtMaxZarazeni.Clear();
                cbZakluchiDen.Checked = false;
                btnIzbrishiDen.Enabled = true;
            }
        }

        private void checkMaxZarazeni()
        {
            if (lbDenovi.Items.Count > 0)
            {
                int maxZarazeni = (int)lbDenovi.Items.OfType<Day>().Select(d => d.Zarazeni).Max();
                txtMaxZarazeni.Text = lbDenovi.Items.OfType<Day>().Where(d => d.Zarazeni == maxZarazeni).ToList()[0].ToString();

            }
        }
        private void checkDen()
        {
            if (cbZakluchiDen.Checked)
            {
                txtNLica.Enabled = false;
                txtILica.Enabled = false;
            }
            else
            {
                txtNLica.Enabled = true;
                txtILica.Enabled = true;
            }
        }

        private void cbZakluchiDen_CheckedChanged(object sender, EventArgs e)
        {
            if(lbDenovi.SelectedIndex != -1)
            {
                Day tempDay = (Day)lbDenovi.SelectedItem;
                if (cbZakluchiDen.Checked)
                    tempDay.Zakluchen = true;
                else
                    tempDay.Zakluchen = false;
            }
            checkDen();
        }
    }
}
