using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Malzeme
{
    public partial class MalzemeSinifKarakteristik : System.Web.UI.Page
    {
        MalzemeDbContextDataContext dc = new MalzemeDbContextDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            BindSiniflar();
        }
        #region Binding
          private void BindSiniflar()
        {
            var data= from dd in dc.tSiniflars select dd ;
            ddlSiniflar.DataSource = data;
            ddlSiniflar.DataBind();
        }
        #endregion
      

        protected void btnGiris_Click(object sender, EventArgs e)
        {

        }
    }
}