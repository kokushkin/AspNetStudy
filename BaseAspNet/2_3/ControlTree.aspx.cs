using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2_3
{
    public partial class ControlTree : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            foreach (Control control in Page.Controls)
            {
                Response.Write(control.GetType().ToString() + " - <b>" + control.ID + "</b><br/>");
            }

            Response.Write("<hr/>");
        }
    }
}