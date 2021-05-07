using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class Najava : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPodnesi_Click(object sender, EventArgs e)
        {
            if (txtLozinka.Text == "mb")
            {
                Session["korisnik"] = txtKorisnik.Text; 
                Response.Redirect("GlavnaStranica.aspx");
            }
            else
            {
                if (ViewState["obidi"] == null)
                    ViewState["obidi"] = 1;
                else
                    ViewState["obidi"] = Convert.ToInt32(ViewState["obidi"]) + 1;

                if (Convert.ToInt32(ViewState["obidi"]) > 3)
                {
                    lblObidi.Text = "Nemate povekje obidi!";
                    btnPodnesi.Enabled = false;
                }
                else    
                    lblObidi.Text = ViewState["obidi"].ToString();
            }
        }
    }
}