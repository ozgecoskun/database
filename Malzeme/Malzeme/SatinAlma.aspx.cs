using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Malzeme
{
    public partial class SatinAlma : System.Web.UI.Page
    {
        MalzemeDbContextDataContext dc = new MalzemeDbContextDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                BindMalzemeTuru();
            }
        }
        #region Binding

        private void BindMalzemeTuru()
        {
            var data = from dd in dc.tMlzTurleris select dd;
            ddlMalzemeTuru.DataSource = data;
            ddlMalzemeTuru.DataBind();
        }
        #endregion

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            tMlzSat satınalma = new tMlzSat
            {
                MalzemeBaslikId = Convert.ToInt32(ddlMalzemeTuru.Text),
                FiyatBirimi = txtFiyatBirimi.Text,
                PlanFiyat = txtPlanFiyat.Text,
                PlanFiyatTarihi = Convert.ToDateTime(txtPlanFiyatTarihi.Text),
                AsgariPartiBuyuklugu = txtAsgariPartiBuyuklugu.Text,
                YuvarlamaDegeri = txtYuvarlamaDegeri.Text,
                PlanlananTeslimatSuresi = txtPlanlananTeslimatSuresi.Text,
                SASipaisMetni = txtSASiparisMetni.Text,
                KaydedenKullanici = txtKaydedenKullanici.Text,
                KayitTarihi = Convert.ToDateTime(txtKayitTarihi.Text),
                GuncelleyenKullanici = txtGuncelleyenKullanici.Text,
                GuncellemeTarihi = Convert.ToDateTime(DateTime.Now.ToLongDateString()),
            };
            dc.tMlzSats.InsertOnSubmit(satınalma);
            dc.SubmitChanges();
        }

    }
}