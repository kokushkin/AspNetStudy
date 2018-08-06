using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _5_1_1
{
    public partial class PageProcessor : System.Web.UI.Page
    {
        protected string PageToLoad;

        protected void Page_Load(object sender, System.EventArgs e)
        {
            PageToLoad = Request.QueryString["Page"];
        }
    }
}