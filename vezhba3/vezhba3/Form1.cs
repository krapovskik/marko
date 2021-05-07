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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDodadiVozach_Click(object sender, EventArgs e)
        {
            Form2 vozach_form = new Form2();
            if (vozach_form.ShowDialog() == DialogResult.OK)
                lbVozachi.Items.Add(vozach_form.vozach);
        }

        private void btnIzbrishiVozach_Click(object sender, EventArgs e)
        {
            if (lbVozachi.SelectedIndex != -1)
            {
                if (MessageBox.Show("Dali sakash da go izbrishesh vozachot?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lbVozachi.Items.Remove(lbVozachi.SelectedItem);
                    lbKrugovi.Items.Clear();
                    txtBestLap.Clear();
                }
            }
        }

        
        private void nudSek_ValueChanged(object sender, EventArgs e)
        {
            if (nudSek.Value == -1)
            {
                if (nudMin.Value != 0)
                {
                    nudSek.Value = 59;
                    nudMin.Value -= 1;
                }
                else
                    nudSek.Value = 0;
            }
            else if (nudSek.Value == 60)
            {
                nudSek.Value = 0;
                nudMin.Value += 1;
            }
        }

        private void btnDodadiKrug_Click(object sender, EventArgs e)
        {
            if (lbVozachi.SelectedIndex != -1)
            {
                ((Vozach)lbVozachi.SelectedItem).laps.Add(DateTime.ParseExact(nudMin.Value + ":" + nudSek.Value,"m:s",null));
                nudMin.Value = 0;
                nudSek.Value = 0;
                updateLaps();
            }
        }

        private void updateLaps()
        {
            Vozach vozach = (Vozach)lbVozachi.SelectedItem;
            if (vozach != null)
            {
                DateTime temp = new DateTime().AddSeconds((int)nudVreme.Value);
                lbKrugovi.DataSource = vozach.laps
                    .Where(time => time.TimeOfDay>temp.TimeOfDay)
                    .ToList()
                    .ConvertAll(time => time.ToString("m:ss"));
                if (vozach.laps.Count !=0)
                    txtBestLap.Text = vozach.laps
                        .OrderBy(time => time)
                        .ToList()[0]
                        .ToString("m:ss");
            }
        }

        private void lbVozachi_SelectedIndexChanged(object sender, EventArgs e)
        {
           updateLaps();
        }

        private void nudVreme_ValueChanged(object sender, EventArgs e)
        {
            updateLaps();
        }
    }
}
