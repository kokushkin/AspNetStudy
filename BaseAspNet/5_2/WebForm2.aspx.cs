using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _5_2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WebForm1 prevPage = PreviousPage as WebForm1;
            if (prevPage != null)
            {
                if(!PreviousPage.IsValid)
                {
                    Response.Redirect(Request.UrlReferrer.AbsolutePath + "?err=true");
                }
                else
                {
                    Label1.Text = prevPage.FullName;
                }
            }               
         }
    }
    
}