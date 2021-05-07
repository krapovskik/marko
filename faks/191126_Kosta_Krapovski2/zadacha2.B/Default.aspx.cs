using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPodnesi_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtGodiniZanimanje.Text) > 5)
                lblSmetka.Text = string.Format("{0} {1} со ID {2} има занимање {3}", txtIme.Text, txtPrezime.Text, txtID.Text,ddlZanimanje.SelectedItem.Text);
            else
                lblSmetka.Text = "Нема доволно години на занимање.";
        }
    }
}