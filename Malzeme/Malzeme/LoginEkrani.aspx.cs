using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Malzeme
{
    public partial class LoginEkranii : System.Web.UI.Page
    {
        MalzemeDbContextDataContext dc = new MalzemeDbContextDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindBolum();
            }

        }

        private void BindBolum()
        {
            var data = from dd in dc.tBolumlers
                       select dd;
            //ddlBolum.DataSource = data;
            //ddlBolum.DataBind();


        }
     
        protected void btnYeniKayit_Click(object sender, EventArgs e)
        {
            Response.Redirect("MalzemeGenel.aspx");
        }

        protected void btnGiris_Click(object sender, EventArgs e)
        { 
            var user = dc.tKullaniciBilgis.Where(x => x.KullaniciAdi ==txtKullaniciAdi.Text && x.Sifre == txtSifre.Text);
           //kullanıcı kontrolu yapılıyor
            if (user.Count() > 0)
            {
                // Session["UserId"] = user.First().Id;
                //int statu1 = user.First().s kullanıclar tablosundakı yetkı grubu gelıcek
                int statu = user.First().BolumlerID;// user.First().Statu
                Session["UserStatu"] = statu;
                //kullanıcı statulerı ıle oturum acıldı ve ilgili sayfaya yonlendırılıyor

                if (statu == (int)KullaniciBolum.Arge)
                {
                    Response.Redirect("MalzemeGenel.aspx");

                }
                else
                    Response.Redirect("AramaSayfasi.aspx");
            }
            else
                Response.Write("<script>alert('Kullanıcı Bulunamadı')</script>");

          
        }


        
       enum KullaniciBolum
        { 
        Arge=1,
        SatinAlma=2,
        Finans=3,
        BilgiIslem =4

        }

    }

}
