using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                btnPrvaStrana.Enabled = false;
            }
        }

        protected void btnProveri_Click(object sender, EventArgs e)
        {
            if (txtPoraka.Text.Equals(txtLozinka.Text))
               SetFocus(txtPoraka);
            else
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Error!');", true);
        }

        protected void btnPrvaStrana_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void txtPoraka_TextChanged(object sender, EventArgs e)
        {
            btnPrvaStrana.Enabled = true;
        }
    }
}