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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AllConferences.conferences = new List<Konf>();
            cbGodina.Items.Add("(none)");
            cbGodina.SelectedIndex = 0;
        }

        private void updateConferences()
        {
            if (cbGodina.SelectedIndex != -1 && !cbGodina.SelectedItem.Equals("(none)"))
            {
                int godina = (int)cbGodina.SelectedItem;
                lbKonferecii.DataSource = null;
                lbKonferecii.DataSource = AllConferences.conferences.Where(c => c.Year == godina).ToList();
            }
            else
            {
                lbKonferecii.DataSource = null;
                lbKonferecii.DataSource = AllConferences.conferences;
            }
        }

        private void btnDodadi_Click(object sender, EventArgs e)
        {
            Konferencija konferencija = new Konferencija();
            if (konferencija.ShowDialog() == DialogResult.OK)
            {
                AllConferences.conferences.Add(konferencija.konferencija);
                if (!cbGodina.Items.Contains(konferencija.konferencija.Year))
                    cbGodina.Items.Add(konferencija.konferencija.Year);
                updateConferences();
            }
        }

        private void btnIzbrishi_Click(object sender, EventArgs e)
        {
            if (lbKonferecii.SelectedIndex != -1)
            {
                Konf temp = (Konf)lbKonferecii.SelectedItem;
                if (AllConferences.conferences.GroupBy(k => k.Year).ToDictionary(k => k.Key,k => k.ToList())[temp.Year].Count() == 1)
                    cbGodina.Items.Remove(temp.Year);
                AllConferences.conferences.Remove(temp);
                updateConferences();
            }
        }

        private void cbGodina_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateConferences();
        }
    }
}
