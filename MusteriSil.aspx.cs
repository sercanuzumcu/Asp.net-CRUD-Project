using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiparisListeleme
{
    public partial class MusteriSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int Id = int.Parse(Request.QueryString["Id"].ToString());

            Session["Id"] = Id;
            Musteri m = new Musteri(Id);
            lblMusteri.Text = m.Firm;
        }

        protected void lnkEvet_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(Session["Id"].ToString());

            Musteri m = new Musteri(Id);
            m.Delete();

            Response.Redirect("MusteriListele.aspx");
        }
    }
}