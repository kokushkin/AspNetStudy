using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _6_7_DataSet
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString =
            WebConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;
            SqlConnection connect = new SqlConnection(connectionString);

            string sqlCat = "SELECT CategoryID, CategoryName FROM Categories";
            string sqlProd = "SELECT ProductName, CategoryID FROM Products";

            SqlDataAdapter adapter = new SqlDataAdapter(sqlCat, connect);
            DataSet dataset = new DataSet();

            try
            {
                connect.Open();

                // Наполнить DataSet данными из таблицы Categories
                adapter.Fill(dataset, "Categories");

                // Изменить текст команды и извлечь данные таблицы Products. 
                // Для решения этой задачи можно было бы также использовать 
                // другой объект
                adapter.SelectCommand.CommandText = sqlProd;
                adapter.Fill(dataset, "Products");
            }
            finally
            {
                connect.Close();
            }

            // Определить отношение между таблицами Categories и Products
            DataRelation relat = new DataRelation("CatProds",
                dataset.Tables["Categories"].Columns["CategoryID"],
                dataset.Tables["Products"].Columns["CategoryID"]);

            // Добавить отношение в DataSet
            dataset.Relations.Add(relat);

            // Пройти в цикле по всем записям о категориях
            foreach (DataRow row in dataset.Tables["Categories"].Rows)
            {
                Label1.Text += String.Format("<b>{0}</b><br><ul>", row["CategoryName"]);

                // Получить связанные товары
                DataRow[] childRows = row.GetChildRows(relat);

                foreach (DataRow childRow in childRows)
                {
                    Label1.Text += String.Format("<li>{0}</li>", childRow["ProductName"]);
                }
                Label1.Text += "</ul>";
            }
        }
    }
}