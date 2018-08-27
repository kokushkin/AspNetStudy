using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _5_9_1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cmdRefreshTime_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(10000);
            Label1.Text = DateTime.Now.ToLongTimeString();
        }
    }
}