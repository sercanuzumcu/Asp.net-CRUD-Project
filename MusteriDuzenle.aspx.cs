using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiparisListeleme
{
    public partial class MusteriDuzenle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
               
            }
            else
            {
                int Id = int.Parse(Request.QueryString["Id"].ToString());
                Session["Id"] = Id;
                Musteri m = new Musteri(Id);
                txtMusteri.Text = m.Firm;
            }
        }

        protected void lnkSakla_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(Session["Id"].ToString());
            String txtYeniMusteri = txtMusteri.Text;
            Musteri m = new Musteri(Id);
            m.Firm = txtYeniMusteri;
            m.Save();
            Response.Redirect("MusteriListele.aspx");
        }
    }
}