using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Malzeme
{
    public partial class AramaSayfasi : System.Web.UI.Page
    {
        MalzemeDbContextDataContext dc = new MalzemeDbContextDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {

                txtBolum.Text = Session["UserStatu"].ToString();
            }

            //BindBolum();
        }



        #region Binding
        //private void BindBolum()
        //{

        //    var data = from dd in dc.tBolumlers select dd;

        //    ddlBolum.DataSource = data;
        //    ddlBolum.DataBind();
        //}

        #endregion
        protected void btnAra_Click(object sender, EventArgs e)
        {

            int statu = Convert.ToInt32(Session["UserStatu"]);

            //statu ye gore veya girilen malzeme koduna gore arama işlemi yapıyor

            //if (!string.IsNullOrEmpty(txtMalzemeKodu.Text) && string.IsNullOrEmpty(txtBolum.Text))
            //{
            //    var data = from dd in dc.tMlzGenels
            //               where (dd.MalzemeKodu == int.Parse(txtMalzemeKodu.Text))
            //               select dd;
            //    if (data.Count() > 0)
            //    {
            //        grdListe.DataSource = data;
            //        grdListe.DataBind();
            //    }
            //}
            if (string.IsNullOrEmpty(txtMalzemeKodu.Text) && !string.IsNullOrEmpty(txtBolum.Text))
            {

                var data = from dd in dc.tMlzGenels
                           where (dd.IdOnayDurumu.Equals(statu))
                           select dd;
                if (data.Count() > 0)
                {
                    grdListe.DataSource = data;
                    grdListe.DataBind();
                }
                else
                {
                    Response.Write("<script>alert('Veri Bulunamadı')</script>");

                }
            }
            else if (!string.IsNullOrEmpty(txtMalzemeKodu.Text) && !string.IsNullOrEmpty(txtBolum.Text))
            {
                var data = from dd in dc.tMlzGenels
                           where (dd.IdOnayDurumu.Equals(statu) && dd.MalzemeKodu.Equals(int.Parse(txtMalzemeKodu.Text)))
                           select dd;
                if (data.Count() > 0)
                {
                    grdListe.DataSource = data;
                    grdListe.DataBind();
                }
                else
                {
                    Response.Write("<script>alert('Veri Bulunamadı')</script>");

                }
            }



        }


    }
}