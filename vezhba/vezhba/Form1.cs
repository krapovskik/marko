using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vezhba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddAirport_Click(object sender, EventArgs e)
        {
            Form2 add_airport = new Form2();
            if (add_airport.ShowDialog() == DialogResult.OK)
            {
                lbAerodromi.Items.Add(add_airport.MyAirport);
            }
        }

        private void btnDeleteAirport_Click(object sender, EventArgs e)
        {
            if (lbAerodromi.SelectedIndex != -1)
            {
                lbAerodromi.Items.Remove(lbAerodromi.SelectedItem);
            }
            else
            {
                MessageBox.Show("Selektiraj aerodrom!");
            }
        }

        private void UpdateMaxPriceAndAvgDestination()
        {
            if (((Aerodrom)lbAerodromi.SelectedItem).destinations.Count > 0)
            {
                txtMaxPrice.Text = ((Aerodrom)lbAerodromi.SelectedItem)
                    .destinations
                    .OrderBy(d => d.Distance)
                    .Reverse()
                    .ToList()[0]
                    .ToString();

                txtAvgDistance.Text = ((Aerodrom)lbAerodromi.SelectedItem)
                    .destinations
                    .Select(d => d.Distance)
                    .Average()
                    .ToString(".00");
            }
        }
        private void UpdateDestinations()
        {
            lbDestinacie.Items.Clear();
            txtMaxPrice.Clear();
            txtAvgDistance.Clear();
            Aerodrom temp = (Aerodrom)lbAerodromi.SelectedItem;
            if (temp != null)
            {
                foreach (Destination d in temp.destinations)
                    lbDestinacie.Items.Add(d);
                UpdateMaxPriceAndAvgDestination();
            }
            else
                lbDestinacie.Items.Clear();
        }

        private void btnAddDestination_Click(object sender, EventArgs e)
        {
            if (lbAerodromi.SelectedIndex != -1)
            {
                Form3 add_destination = new Form3();
                if (add_destination.ShowDialog() == DialogResult.OK)
                {
                    Aerodrom temp = (Aerodrom)lbAerodromi.SelectedItem;
                    temp.destinations.Add(add_destination.MyDestination);
                    UpdateDestinations();
                }
            }
            else
            {
                MessageBox.Show("Selektiraj aerodrom!");
            }
        }

        private void lbAerodromi_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDestinations();
        }
    }
}
