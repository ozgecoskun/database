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
            BindOnayDurum();
        }

        #region Binding
        private void BindOnayDurum()
        {
            var data = from dd in dc.tOnayDurums select dd;

            ddlOnayDurum.DataSource = data;
            ddlOnayDurum.DataBind();
        }
        
        #endregion
        protected void btnAra_Click(object sender, EventArgs e)
        {


        }

       
    }
}