using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _6_8_DataView_Relation_Filter
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Строка подключения из файла web.config
            string connectionString =
                WebConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;
            SqlConnection connect = new SqlConnection(connectionString);

            string sqlCat = "SELECT CategoryID, CategoryName FROM Categories";
            string sqlProd = "SELECT ProductName, CategoryID, UnitPrice FROM Products";

            SqlDataAdapter adapter = new SqlDataAdapter(sqlCat, connect);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset, "Categories");

            adapter.SelectCommand.CommandText = sqlProd;
            adapter.Fill(dataset, "Products");

            // Связать таблицы Categories и Products в DataSet
            DataRelation relation = new DataRelation("CatProds",
                dataset.Tables["Categories"].Columns["CategoryID"],
                dataset.Tables["Products"].Columns["CategoryID"]);

            dataset.Relations.Add(relation);

            // Фильтровать категории, в которых есть товары дороже $50
            DataView view = new DataView(dataset.Tables["Categories"]);
            view.RowFilter = "MAX(Child(CatProds).UnitPrice) > 80";
            GridView1.DataSource = view;

            // Скопировать данные из привязанных DataSet (DataView)
            Page.DataBind();
        }
    }
}