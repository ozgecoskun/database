using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Malzeme
{
    public partial class MalzemeBaslik : System.Web.UI.Page
    {
        MalzemeDbContextDataContext dc = new MalzemeDbContextDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                BindMalzemeTuru();
                BindUretimYeri();
                BindOnayDurum();
            }
        }


        #region Binding
        private void BindMalzemeTuru()
        {
            var data = from dd in dc.tMlzTurleris select dd;
            ddlMalzemeTuru.DataSource = data;
            ddlMalzemeTuru.DataBind();
        }
        private void BindOnayDurum()
        {
            var data = from dd in dc.tOnayDurums select dd;
            ddlOnayDurumu.DataSource = data;
            ddlOnayDurumu.DataBind();
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
            tMlzBaslik baslik = new tMlzBaslik
            {
                IdMalzemeTuru = Convert.ToInt32(ddlMalzemeTuru.Text),
                MalzemeNo = txtMalzemeNo.Text,
                MalzemeAdi = txtMalzemeAdi.Text,
                IdUretimYeri = Convert.ToInt32(ddlUretimYeri.Text),
                MalzemeDurum = txtMalzemeDurumu.Text,
                KaydedenKullanici = txtKaydedenKullanici.Text,
                KayitTarihi = Convert.ToDateTime(txtKayitTarihi.Text),
                GuncelleyenKullanici = txtGuncelleyenKullanici.Text,
                GuncellemeTarihi = Convert.ToDateTime(DateTime.Now.ToLongDateString()),
                IdOnayDurum = Convert.ToInt32(ddlOnayDurumu.Text)
            };
            dc.tMlzBasliks.InsertOnSubmit(baslik);
            dc.SubmitChanges();
        }

        protected void btnCoklama_Click(object sender, EventArgs e)
        {
            tMlzBaslik baslik = new tMlzBaslik
            {
                IdMalzemeTuru = Convert.ToInt32(ddlMalzemeTuru.Text),
                MalzemeNo = txtMalzemeNo.Text,
                MalzemeAdi = txtMalzemeAdi.Text,
                IdUretimYeri = Convert.ToInt32(ddlUretimYeri.Text),
                MalzemeDurum = txtMalzemeDurumu.Text,
                KaydedenKullanici = txtKaydedenKullanici.Text,
                KayitTarihi = Convert.ToDateTime(txtKayitTarihi.Text),
                GuncelleyenKullanici = txtGuncelleyenKullanici.Text,
                GuncellemeTarihi = Convert.ToDateTime(DateTime.Now.ToLongDateString()),
                IdOnayDurum = Convert.ToInt32(ddlOnayDurumu.Text)
            };
            dc.tMlzBasliks.InsertOnSubmit(baslik);
            dc.SubmitChanges();

        }
    }
}