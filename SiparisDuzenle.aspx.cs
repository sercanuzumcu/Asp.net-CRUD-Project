using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiparisListeleme
{
    public partial class SiparisDuzenle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                


                int Id = int.Parse(Request.QueryString["Id"].ToString());
               
                
                Session["SiparisId"] = Id;

                Musteri m = new Musteri();
                drpMusteriId.DataSource = m.GetAll();
                drpMusteriId.DataValueField = "Id";
                drpMusteriId.DataTextField = "Firm";
                drpMusteriId.DataBind();

                drpSiparisDurumId.DataSource = SiparisDurum.getAllSiparisDurum();
                drpSiparisDurumId.DataValueField = "SiparisDurumId";
                drpSiparisDurumId.DataTextField = "SiparisDurumText";
                drpSiparisDurumId.DataBind();

                Siparis s = new Siparis(Id);
                drpMusteriId.SelectedValue = s.MusteriId.ToString();
                txtAciklama.Text = s.AciklamaText;
                txtUrun.Text = s.SiparisText;
                txtAdet.Text = s.AdetText.ToString();
                drpSiparisDurumId.SelectedValue = s.SiparisDurumId.ToString();




          
            }
        }
        protected void lnkSend_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(Session["SiparisId"].ToString());
            Siparis s = new Siparis(Id);

            s.MusteriId = int.Parse(drpMusteriId.SelectedValue);
            s.AciklamaText = txtAciklama.Text;
            s.SiparisText = txtUrun.Text;
            s.AdetText = int.Parse(txtAdet.Text);
            s.SiparisDurumId = int.Parse(drpSiparisDurumId.SelectedValue);

            s.Save();

            Response.Redirect("SiparisListele.aspx");
        }
    }
}