using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _5_5_1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Panel1_Refreshing(object sender, EventArgs e)
        {
            Label1.Text = "Произошло обновление страницы с использованием обратного вызова. " +
                "Серверное время: " + DateTime.Now.ToString();
        }
    }
}