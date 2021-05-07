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
            
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            string name = txtIme.Text;
            string lastname = txtPrezime.Text;
            Response.Redirect("Default2.aspx?name="+name+"&lastname="+lastname+"");
        }
    }
}