using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vezhba2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDodadiProdukt_Click(object sender, EventArgs e)
        {
            NewProduct newProduct = new NewProduct();
            if (newProduct.ShowDialog() == DialogResult.OK)
            {
                lbProdukti.Items.Add(newProduct.product);
            }
        }

        private void btnIzbrishiProdukt_Click(object sender, EventArgs e)
        {
           if (lbProdukti.SelectedIndex != -1)
            {
                lbProdukti.Items.Remove(lbProdukti.SelectedItem);
            }
        }

        private void updateVkupno()
        {
            List<ProductQuantity> temp = new List<ProductQuantity>();
            foreach (ProductQuantity pq in lbKoshnicha.Items)
                temp.Add(pq);
            txtVkupno.Text = temp.Select(product => product.totalPrice()).Sum().ToString();
        }

        private void btnDodadiKosnica_Click(object sender, EventArgs e)
        {
            if (lbProdukti.SelectedIndex != -1)
            {
                lbKoshnicha.Items.Add(new ProductQuantity((Product)lbProdukti.SelectedItem, nudKolichina.Value));
                updateVkupno();
            }
        }

        private void btnIzbrishiKosnica_Click(object sender, EventArgs e)
        {
            if (lbKoshnicha.SelectedIndex != -1)
            {
                lbKoshnicha.Items.Remove(lbKoshnicha.SelectedItem);
                updateVkupno();
            }
        }

        private void btnIzprazniLista_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Dali ste sigurni deka sakate da ja ispraznite listata na produkti?","Izpraznija listata?",MessageBoxButtons.YesNo) == DialogResult.Yes)
                lbProdukti.Items.Clear();
        }

        private void btnIzprazniKoshnica_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Dali ste sigurni deka sakate da ja ispraznite koshnicata?", "Izpraznija koshnicata?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                lbKoshnicha.Items.Clear();
                txtVkupno.Text = "";
            }
        }

        private void lbProdukti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbProdukti.SelectedIndex != -1)
            {
                txtIme.Text = ((Product)lbProdukti.SelectedItem).Name;
                txtKategorija.Text = ((Product)lbProdukti.SelectedItem).Category;
                txtCena.Text = ((Product)lbProdukti.SelectedItem).Price.ToString(".00");
            }
        }
    }
}
