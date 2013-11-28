using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Malzeme
{

    public partial class MalzemeFinans : System.Web.UI.Page
    {
        MalzemeDbContextDataContext dc = new MalzemeDbContextDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindMalzemeTuru();
                BindiDegerlemeTipi();
                BindingKarMerkezi();
                BindingKDVOrani();

            }
        }





        #region Binding

        private void BindMalzemeTuru()
        {
            var data = from dd in dc.tMlzTurleris select dd;
            ddlMalzemeTuru.DataSource = data;
            ddlMalzemeTuru.DataBind();
        }
        private void BindiDegerlemeTipi()
        {
            var data = from dd in dc.tDgrTipis select dd;
            ddlDegerlemeTipi.DataSource = data;
            ddlDegerlemeTipi.DataBind();
        }
        private void BindingKarMerkezi()
        {
            var data = from dd in dc.tKarMerkezis select dd;
            ddlKarMerkezi.DataSource = data;
            ddlKarMerkezi.DataBind();
        }
        private void BindingKDVOrani()
        {
            var data = from dd in dc.tKDVs select dd;
            ddlKDVOrani.DataSource = data;
            ddlKDVOrani.DataBind();
        }

        #endregion

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            tMlzFin fin = new tMlzFin
            {
                MalzemeBaslikId = Convert.ToInt32(ddlMalzemeTuru.Text),
                IdDegerlemetipi = Convert.ToInt32(ddlDegerlemeTipi.Text),
                IdKarMerkezi = Convert.ToInt32(ddlKarMerkezi.Text),
                MaliyetHesaplamaPartiBuyuklugu = txtMaliyetHesaplamaPartiByklugu.Text,
                IdKDVOranı = Convert.ToInt32(ddlKDVOrani.Text),
                KaydedenKullanici = txtKaydedenKullanici.Text,
                KayitTarihi = Convert.ToDateTime(txtKayitTarihi.Text),
                GuncelleyenKullanici = txtGuncelleyenKullanici.Text,
                GuncellemeTarihi = Convert.ToDateTime(DateTime.Now.ToLongDateString()),

            };
            dc.tMlzFins.InsertOnSubmit(fin);
            dc.SubmitChanges();
        }
    }

}