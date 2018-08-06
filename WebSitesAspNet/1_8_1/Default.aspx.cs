using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1_7_1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //SiteTemplate master = (SiteTemplate)this.Master;
            //master.BannerText = "Страница #1";
            
            this.Master.BannerText = "Страница #1";
        }
    }
}