using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Malzeme
{
    public partial class MalzemeGenel : System.Web.UI.Page
    {
        MalzemeDbContextDataContext dc = new MalzemeDbContextDataContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindMalzemeTuru();
                BindUretimYeri();
                BindTemelOlcuBirimi();
                BindMalGrubu();
                BindMIPKrk();
                BindMIPSorumlusu();
                BindTedarikTuru();
                BindOnayDurum();

                txtKayitTarihi.Text = DateTime.Now.ToShortDateString();

                int id = Convert.ToInt32(Request.QueryString["id"]);

            }



        }





        #region Binding
        private void BindOnayDurum()
        {
            var data = from dd in dc.tOnayDurums select dd;

            ddlOnayDurum.DataSource = data;
            ddlOnayDurum.DataBind();
        }
        private void BindMalzemeTuru()
        {
            var data = from dd in dc.tMlzTurleris select dd;
            ddlMalzemeTuru.DataSource = data;
            ddlMalzemeTuru.DataBind();
        }

        private void BindTemelOlcuBirimi()
        {
            var data = from dd in dc.tTOBs select dd;
            ddlTemelOlcuBirimi.DataSource = data;
            ddlTemelOlcuBirimi.DataBind();
        }

        private void BindMalGrubu()
        {
            var data = from dd in dc.tMalGrubus select dd;
            ddlMalGrubu.DataSource = data;
            ddlMalGrubu.DataBind();
        }

        private void BindMIPKrk()
        {
            var data = from dd in dc.tMipKrks select dd;
            ddlMIPKarakteristigi.DataSource = data;
            ddlMIPKarakteristigi.DataBind();
        }

        private void BindMIPSorumlusu()
        {
            var data = from dd in dc.tMipSrmlus select dd;
            ddlMipSorumlusu.DataSource = data;
            ddlMipSorumlusu.DataBind();
        }
        private void BindTedarikTuru()
        {
            var data = from dd in dc.tTdrkTurus select dd;
            ddlTedarikTuru.DataSource = data;
            ddlTedarikTuru.DataBind();

        }

        private void BindUretimYeri()
        {
            var data = from dd in dc.tUYs select dd;
            ddlUretimYeri.DataSource = data;
            ddlUretimYeri.DataBind();
        }



        #endregion

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            tMlzGenel genel = new tMlzGenel
            {
                MalzemeKodu = Convert.ToInt32(txtMalzemeKodu.Text),
                IdMalzemeTuru = Convert.ToInt32(ddlMalzemeTuru.Text),
                IdUretimYeri = Convert.ToInt32(ddlUretimYeri.Text),
                DepoYeri = txtDepoYeri.Text,
                MalzemeKısaMetni = txtMalzemeKısaMetni.Text,
                IdTemelOlcuBirimi = Convert.ToInt32(ddlTemelOlcuBirimi.Text),
                IdMalGrubu = Convert.ToInt32(ddlMalGrubu.Text),
                IdMIPKarakteristligi = Convert.ToInt32(ddlMIPKarakteristigi.Text),
                IdMIPSorumlusu = Convert.ToInt32(ddlMipSorumlusu.Text),
                MIPPartiBuyuklugu = txtMipPartiBuyuklugu.Text,
                IdTedarikTuru = Convert.ToInt32(ddlTedarikTuru.Text),
                UretimDenetimSorumlusu = txtUretimDenetimSorumlusu.Text,
                UretimDenetimProfii = txtUretimDenetimProfili.Text,
                DepoAdresi = txtDepoAdresi.Text,
                EmliyetStogu = txtEmniyetStogu.Text,
                KaydedenKullanici = txtKaydedenKullanici.Text,
                KayitTarihi = Convert.ToDateTime(txtKayitTarihi.Text),
                GuncelleyenKullanici = txtGuncelleyenKullanici.Text,
                GuncellemeTarihi = Convert.ToDateTime(DateTime.Now.ToLongDateString()),

            };
            dc.tMlzGenels.InsertOnSubmit(genel);
            dc.SubmitChanges();
        }

        protected void btnYeniKayit_Click(object sender, EventArgs e)
        {
            //txtKaydedenKullanici.Text = " ";
            foreach (Control t in this.Controls)
            {
                if (t is TextBox)
                {
                    ((TextBox)t).Text = " ";
                }
            }




          
        }

        

    }
}