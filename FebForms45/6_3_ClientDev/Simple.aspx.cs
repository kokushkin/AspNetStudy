using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClientDev
{
    public partial class Simple : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            this.MasterPageFile = Request.Browser.IsMobileDevice ?
                "Site.Mobile.Master" : "Site.Master";
        }
    }
}