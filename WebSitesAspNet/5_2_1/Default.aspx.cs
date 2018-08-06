using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _5_2_1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "Вы вставили: " + Server.HtmlEncode(txtInput.Text); //txtInput.Text;
        }

        protected void cmdSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}