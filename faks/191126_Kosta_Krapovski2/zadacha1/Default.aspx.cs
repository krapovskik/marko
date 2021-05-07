using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                List<string> meseci = new List<string>() { "","Јануари", "Февруари", "Март", "Април", "Мај", "Јуни", "Јули", "Август", "Септември", "Октомври", "Ноември", "Декември"};
                ddlMesec.DataSource = meseci;
                ddlMesec.DataBind();
                int godina = DateTime.Now.Year;
                List<int> temp_godini = new List<int>();
                for (int i = godina; i < godina + 5; i++)
                {
                    temp_godini.Add(i);
                }
                ddlGodina.DataSource = temp_godini;
                ddlGodina.DataBind();
                List<string> vreme_na_poagjanje = new List<string>();
                for (int i = 0; i < 23;i++)
                {
                    DateTime start = new DateTime().AddHours(i);
                    DateTime end = new DateTime().AddHours(i + 1);
                    StringBuilder sb = new StringBuilder();
                    sb.Append(start.ToString("HH:mm")).Append('-').Append(end.ToString("HH:mm"));
                    vreme_na_poagjanje.Add(sb.ToString());
                }
                ddlVreme.DataSource = vreme_na_poagjanje;
                ddlVreme.DataBind();
            }
        }

        private void checkDenovi()
        {
            List<string> meseci31 = new List<string>() { "Јануари", "Март", "Мај", "Јули", "Август", "Октомври", "Декември" };
            List<string> meseci30 = new List<string>() { "Април", "Јуни", "Септември", "Ноември" };
            List<int> temp = new List<int>();
            if (ddlMesec.SelectedIndex != 0)
            {

                if (meseci31.Contains(ddlMesec.SelectedItem.Text))
                {
                    for (int i = 1; i <= 31; i++)
                    {
                        temp.Add(i);
                    }
                }
                else if (meseci30.Contains(ddlMesec.SelectedItem.Text))
                {
                    for (int i = 1; i <= 30; i++)
                    {
                        temp.Add(i);
                    }
                }
                else
                {
                    if (DateTime.IsLeapYear(Convert.ToInt32(ddlGodina.SelectedItem.Text)))
                    {
                        for (int i = 1; i <= 29; i++)
                        {
                            temp.Add(i);
                        }
                    }
                    else
                    {
                        for (int i = 1; i <= 28; i++)
                        {
                            temp.Add(i);
                        }
                    }
                }
            }
            ddlDen.DataSource = temp;
            ddlDen.DataBind();
        }

        protected void ddlMesec_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkDenovi();
        }

        protected void ddlGodina_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkDenovi();
        }

        protected void btnPodnesi_Click(object sender, EventArgs e)
        {
            lblPatnik.Text = string.Format("{0} {1}",txtIme.Text,txtPrezime.Text);
            lblSredstvo.Text = lbSredstvo.SelectedItem.Text;
            lblOd.Text = ddlOd.SelectedItem.Text;
            lblDo.Text = ddlDo.SelectedItem.Text;
            lblVreme.Text = ddlVreme.SelectedItem.Text;
            lblZona.Text = rblZona.SelectedItem.Text;
            lblKlasa .Text = rblKlasa.SelectedItem.Text;
            lblPosluga.Text = cblPosluga.SelectedItem.Text;
            List<string> prevozno_sredstvo_img = new List<string>() { "https://cdn.britannica.com/69/155469-131-14083F59/airplane-flight.jpg", "https://www.arabnews.com/sites/default/files/styles/n_670_395/public/2020/07/18/2193451-945114106.jpg?itok=ANJ8BZY-" };
            if (lbSredstvo.SelectedItem.Text.Equals("Воз")) imgSlika.ImageUrl = prevozno_sredstvo_img[1];
            else imgSlika.ImageUrl = prevozno_sredstvo_img[0];
        }
    }
}