using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _7_5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void gridEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = gridEmployees.SelectedIndex;

            //  Ключевое поле можно извлечь из свойства SelectedDataKey
            int ID = (int)gridEmployees.SelectedDataKey.Values["EmployeeID"];

            // Другие данные можно извлечь непосредственно из коллекции Cells
            string firstName = gridEmployees.SelectedRow.Cells[2].Text;
            string lastName = gridEmployees.SelectedRow.Cells[3].Text;

            lblRegionCaption.Text = "Сотрудник <b>" + firstName + " " + lastName +
                "</b> (ID=" + ID.ToString() + ") отвечает за:";
        }
    }
}