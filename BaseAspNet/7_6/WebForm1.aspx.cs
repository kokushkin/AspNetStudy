using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _7_6
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // Обработчики
        protected void lstSorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            gridEmployees.Sort(lstSorts.SelectedValue, SortDirection.Ascending);
        }

        protected void gridEmployees_Sorting(object sender, GridViewSortEventArgs e)
        {
            if (e.SortExpression == "FirstName" && gridEmployees.SortExpression == "LastName")
            {
                // На основе текущей сортировки и запрошенной 
                // строится выражение для составной сортировки
                e.SortExpression = "LastName, FirstName";
            }
        }
    }
}