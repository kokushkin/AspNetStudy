using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _7_4_2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                // Получить дату рождения
                DateTime birthDate = (DateTime)DataBinder.Eval(e.Row.DataItem, "BirthDate");

                // Форматирование строк на основе даты рождения сотрудника
                if (birthDate.Year <= 1955)
                {
                    e.Row.BackColor = System.Drawing.Color.LightPink;
                    e.Row.ForeColor = System.Drawing.Color.Maroon;
                }
                else if (birthDate.Year > 1955 && birthDate.Year <= 1960)
                {
                    e.Row.BackColor = System.Drawing.Color.LightCyan;
                    e.Row.ForeColor = System.Drawing.Color.DarkBlue;
                }
                else
                {
                    e.Row.BackColor = System.Drawing.Color.LimeGreen;
                    e.Row.ForeColor = System.Drawing.Color.White;
                }
            }
        }
    }
}