using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace _3_2_2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Создать новый объект HtmlTable
            HtmlTable table1 = new HtmlTable();

            // Установить свойства форматирования таблицы
            table1.Border = 1;
            table1.CellPadding = 3;
            table1.CellSpacing = 3;
            table1.BorderColor = "red";

            // Начать добавлять содержимое в таблицу
            HtmlTableRow row;
            HtmlTableCell cell;

            for (int i = 1; i <= 5; i++)
            {
                // Создать новую строку и установить для нее цвет фона
                row = new HtmlTableRow();
                row.BgColor = (i % 2 == 0 ? "lightyellow" : "lightcyan");

                for (int j = 1; j <= 4; j++)
                {
                    // Создать ячейку и установить ее текст
                    cell = new HtmlTableCell();
                    cell.InnerHtml = "Row: " + i.ToString() +
                        "<br />Cell: " + j.ToString();

                    // Добавить ячейку в текущую строку
                    row.Cells.Add(cell);
                }

                // Добавить строку в таблицу
                table1.Rows.Add(row);
            }

            // Добавить таблицу внутрь страницы
            this.Controls.Add(table1);

        }
    }
}