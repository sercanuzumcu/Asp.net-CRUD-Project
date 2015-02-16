using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiparisListeleme
{
    public partial class MusteriListele : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Musteri m = new Musteri();
            List<Musteri> musteriler = m.GetAll();
            rptBrand.DataSource = musteriler;
            rptBrand.DataBind();
        }
    }
}