using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2_2_1
{
    public partial class Products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string productID = (string)Page.RouteData.Values["productID"];
            // Выполнить какие-то операции, например, запрос к базе данных
            HyperLink1.NavigateUrl = Page.GetRouteUrl("product-details", new { productID });
        }
    }
}