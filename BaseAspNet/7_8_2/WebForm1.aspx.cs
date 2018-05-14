using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _7_8_2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected string[] TitlesOfCourtesy
        {
            get
            {
                return new string[] { "Mr.", "Dr.", "Ms.", "Mrs." };
            }
        }

        protected int GetSelectedTitle(object title)
        {
            return Array.IndexOf(TitlesOfCourtesy, title.ToString());
        }

        protected void gridEmployees_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            // Получить ссылку на списковый элемент управления
            DropDownList title = (DropDownList)(gridEmployees.Rows[e.RowIndex].FindControl("EditTitle"));

            // Добавить его к параметру
            e.NewValues.Add("TitleOfCourtesy", title.Text);
        }
    }
}