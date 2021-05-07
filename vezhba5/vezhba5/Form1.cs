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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnDodadiAvtomobil.Enabled = false;
        }

        private void btnDodadiMarka_Click(object sender, EventArgs e)
        {
            NovaMarka nm = new NovaMarka();
            if (nm.ShowDialog() == DialogResult.OK)
            {
                lbMarki.Items.Add(nm.marka);
                btnDodadiAvtomobil.Enabled = true;
                cbMarka.DataSource = null;
                cbMarka.DataSource = lbMarki.Items;
            }
        }

        private void update()
        {
            if (lbAvtomobili.Items.Count != 0)
            {
                txtNajekonomichen.Text = lbAvtomobili.Items
                    .OfType<Car>()
                    .OrderBy(c => c.Potroshuvachka)
                    .ToList()[0]
                    .ToString();
                txtNajskap.Text = lbAvtomobili.Items
                    .OfType<Car>()
                    .OrderBy(c => c.Cena)
                    .Reverse()
                    .ToList()[0]
                    .ToString();
                txtPotroshuvachka.Text = lbAvtomobili.Items
                    .OfType<Car>()
                    .Select(c => c.Potroshuvachka)
                    .Average()
                    .ToString();
            }
            else
            {
                txtNajekonomichen.Clear();
                txtNajskap.Clear();
                txtPotroshuvachka.Clear();
            }
            
        }

        private void btnDodadiAvtomobil_Click(object sender, EventArgs e)
        {
            if (cbMarka.SelectedIndex != -1 && txtModel.Text.Trim().Length != 0 && nudPotroshuvachka.Value != 0 && nudCena.Value != 0)
            {
                Car car = new Car((CarMarka)cbMarka.SelectedItem, txtModel.Text, nudPotroshuvachka.Value, Convert.ToInt32(nudCena.Value));
                lbAvtomobili.Items.Add(car);
                update();
            }
            else
            {
                MessageBox.Show("Vnesete validni podatoci!");
            }
        }

        private void btnIzbrishiAvtomobil_Click(object sender, EventArgs e)
        {
            if(lbAvtomobili.SelectedIndex != -1)
            {
                lbAvtomobili.Items.Remove(lbAvtomobili.SelectedItem);
                update();
            }
        }
    }
}
