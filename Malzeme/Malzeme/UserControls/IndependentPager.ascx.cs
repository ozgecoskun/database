using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

public delegate void PageChangedEventHandler(object sender, EventArgs e);

public partial class UserControls_IndependentPager : System.Web.UI.UserControl
{

    public UserControls_IndependentPager()
    {
        TotalRows = 0;
        RowsPerPage = 15;
        CurrentPage = 1;
    }

    public int TotalPages
    {
        get
        {
            return (TotalRows / RowsPerPage) + 1;
        }
    }

    public int TotalRows { get; set; }

    public int RowsPerPage { get; set; }

    public int CurrentPage { get; set; }

    public string Info { get { return string.Format("Toplam {0} kayıt.  {1}/{2} ", TotalRows.ToString(), CurrentPage.ToString(), TotalPages.ToString()); } }

    public class PagerItem
    {

        public int PageNo { get; set; }

        public string Text { get; set; }

    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            List<PagerItem> list = new List<PagerItem>();

            for (int i = 1; i <= TotalPages; i++)
            {
                list.Add(new PagerItem { PageNo = i, Text = i.ToString() });
            }

            hfTotalRows.Value = TotalRows.ToString();

            ltlInfo.Text = Info;

            Repeater1.DataSource = list;
            Repeater1.DataBind();

            RegisterJavascriptToHighlightCurrentPage();
        }
    }

    protected void PagerItem_Click(object sender, EventArgs e)
    {
        LinkButton button = sender as LinkButton;

        CurrentPage = Convert.ToInt32(button.CommandArgument);

        RegisterJavascriptToHighlightCurrentPage();

        //toplam satır değerini hidden fielddan property içine doldur
        this.TotalRows = Convert.ToInt32(hfTotalRows.Value);

        ltlInfo.Text = Info;
        
        NotifyPageChanged(new EventArgs());        
    }

    private void RegisterJavascriptToHighlightCurrentPage()
    {
        this.Page.ClientScript.RegisterStartupScript(this.GetType(), "pager", "$('.pg" + CurrentPage.ToString() + "').addClass('currentPage');", true);
    }

    public event PageChangedEventHandler PageChanged;

    protected virtual void NotifyPageChanged(EventArgs e)
    {
        if (PageChanged != null)
        {
            PageChanged(this, e);
        }
    }

}