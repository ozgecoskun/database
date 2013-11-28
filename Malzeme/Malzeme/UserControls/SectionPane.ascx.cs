using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Template.Web.UserControls
{
    public partial class SectionPane : System.Web.UI.UserControl
    {

        public class Link{
        
            public string Label { get; set; }

            public string Url { get; set; }

        }

        public string Label { get; set; }

        public string Url { get; set; }

        public Link[] Links { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Links != null && Links.Length > 0)
                {
                    repeater1.DataSource = Links;
                    repeater1.DataBind();

                    ulempty.Visible = false;
                    repeater1.Visible = true;
                }
                else
                {
                    repeater1.Visible = false;
                    ulempty.Visible = true;
                }
            }
        }
    }
}