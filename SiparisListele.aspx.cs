using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiparisListeleme
{
    public partial class SiparisListele : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Siparis s = new Siparis();
            rptSiparis.DataSource = s.GetSiparis();
            rptSiparis.DataBind();
        }
    }
}