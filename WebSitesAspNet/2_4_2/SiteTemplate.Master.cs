using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2_2_1
{
    public partial class SiteTemplate : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (SiteMap.CurrentNode.NextSibling != null)
            {
                HyperLink1.NavigateUrl = SiteMap.CurrentNode.NextSibling.Url;
                HyperLink1.Visible = true;
            }
            else
            {
                HyperLink1.Visible = false;
            }
        }
    }
}