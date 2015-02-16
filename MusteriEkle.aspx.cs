using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiparisListeleme
{
    public partial class MusteriEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void lnkEkle_Click(object sender, EventArgs e)
        {
            Musteri m = new Musteri();
            m.Name = txtName.Text;
            m.SurName = txtSurName.Text;
            m.Firm = txtFirm.Text;
            m.TelNo = Convert.ToInt64(txtTelNo.Text);
            m.Email = TxtEmail.Text;
            m.Insert();
            Response.Redirect("index.aspx");
        }
    }
}