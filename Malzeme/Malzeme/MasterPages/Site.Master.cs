using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
//using AracTakip.Business.Domain;

namespace Template.Web.MasterPages
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack){
                //List<EtiAuthMan.User> users = EtiAuthMan.AuthManager.GetAllUsers() as List<EtiAuthMan.User>;

                //this.ltlUserName.Text = users.Where(x => x.UserName == this.Page.User.Identity.Name).Select(x => x.DisplayName).First().ToString() + " @" + EtiAuthMan.AuthManager.ApplicationName;

               // this.ltlUserName.Text = this.Page.User.Identity.Name + " @YOSI";

            }

            
        }

       
        }
    }
