using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiparisListeleme
{
    public partial class SiparisEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Musteri m = new Musteri();

                drpMusteriId.DataSource = m.GetAll();
                drpMusteriId.DataValueField = "Id";
                drpMusteriId.DataTextField = "Firm";
                drpMusteriId.DataBind();

                if (Session["SurekliGiris"] != null && bool.Parse(Session["SurekliGiris"].ToString()) == true)
                {
                    chkSurekliGiris.Checked = true;
                }

          
            }
        }
        protected void lnkSend_Click(object sender, EventArgs e)
        {
            Siparis s = new Siparis();

            s.MusteriId = int.Parse(drpMusteriId.SelectedValue);
            s.AciklamaText = txtAciklama.Text;
            s.SiparisText = txtUrun.Text;
            s.AdetText = int.Parse(txtAdet.Text);

            s.Insert();

            String targetUrl = "SiparisListele.aspx";
            if (chkSurekliGiris.Checked)
            {
                Session["SurekliGiris"] = true;
                targetUrl = "SiparisEkle.aspx";
            }
            
            Response.Redirect(targetUrl);
        }
    }
}