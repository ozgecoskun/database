using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace Template.Web.UserControls
{
    public partial class MainTab : System.Web.UI.UserControl
    {
        public class TabData
        {
            public string Name { get; set; }

            public string Caption { get; set; }

            public string Url { get; set; }

        }

        private TabData[] Tabs { get; set; }

        public string CurrentTab { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void RenderTabs()
        {
            GetTabs();
            BuildTab();
        }

        private void GetTabs()
        {
            Tabs = new TabData[] { 
                new TabData{ Name = "arac", Caption = "Araç", Url = "Arac.aspx" },
                new TabData{ Name = "plaka", Caption = "Plaka", Url = "Plaka.aspx" },
                new TabData{ Name = "kullanici", Caption = "Kullanıcı", Url = "Kullanici.aspx" },
                new TabData{ Name = "firma", Caption = "Firma", Url = "Firma.aspx" },
                new TabData{ Name = "hasar", Caption = "Hasar", Url = "Hasar.aspx" },
                new TabData{ Name = "bakim", Caption = "Bakım", Url = "BakimPage.aspx" },
                new TabData{ Name = "lastik", Caption = "Lastik", Url = "LastikAnasayfa.aspx" },
                new TabData{ Name = "muadilArac", Caption = "Muadil Araç", Url = "muadilarac.aspx" }
            };
        }

        private void BuildTab()
        {
            StringBuilder sbTop = new StringBuilder(@"<td style='width: 18px'></td>");
            StringBuilder sbBottom = new StringBuilder(@"<td class='ftb'></td>");            

            foreach (var item in Tabs)
            {
                string type = "p";

                if (item.Name == CurrentTab)
                    type = "a";

                sbTop.AppendFormat(@"<td class='{0}tt'>", type);
                sbTop.AppendFormat(@"<a class='{0}tt' href='{1}'>", type, item.Url);
                sbTop.AppendFormat(@"<div class='{0}tt'>{1}</div></a></td>", type, item.Caption);

                sbBottom.AppendFormat(@"<td class='{0}tb'></td>", type);
            }

            sbTop.Append(@"<td></td>");
            sbBottom.Append(@"<td class='ltb'></td>");

            ltlTop.Text = sbTop.ToString();
            ltlBottom.Text = sbBottom.ToString();
        }
    }
}