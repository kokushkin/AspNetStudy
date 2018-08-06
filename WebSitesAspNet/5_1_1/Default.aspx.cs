using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _5_1_1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Имитировать медленную загрузку страницы (пятисекундное ожидание)
            System.Threading.Thread.Sleep(5000);
        }
    }
}