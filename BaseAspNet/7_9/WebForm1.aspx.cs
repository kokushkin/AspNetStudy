using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _7_9
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void gridMaster_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            // Поиск элементов данных
            if (e.Row.RowType == DataControlRowType.DataRow)
            {

                // Извлечь элемент управления GridView из второго столбца
                GridView gridChild = (GridView)e.Row.Cells[1].Controls[1];

                // Установить параметр CategoryID так, чтобы получить 
                // товары только текущей категории
                string catID = gridMaster.DataKeys[e.Row.DataItemIndex].Value.ToString();
                getProductsSDS.SelectParameters[0].DefaultValue = catID;

                // Получить объект данных из источника данных
                object data = getProductsSDS.Select(DataSourceSelectArguments.Empty);

                // Привязать сетку
                gridChild.DataSource = data;
                gridChild.DataBind();
            }
        }
    }
}