using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _7_8_1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected string GetStatusPicture(object dataItem)
        {
            // Получить количество товара на складе
            int count = Int32.Parse(
                DataBinder.Eval(dataItem, "UnitsInStock").ToString());

            return count == 0 ? "Cancel.gif" : "OK.gif"; // Эти рисунки должны быть добавлены в проект
        }

        protected void gridEmployees_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "StatusClick")
                Label1.Text = "Вы выбрали <b>" + e.CommandArgument + "</b>";
        }
    }
}