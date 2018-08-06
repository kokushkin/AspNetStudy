using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2_6_1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                // Извлечь DataSet с помощью вспомогательного метода
                DataSet ds = GetProductsAndCategories();

                // Циклический проход по записям категорий
                foreach (DataRow row in ds.Tables["Categories"].Rows)
                {
                    // Создать пункт меню для категории
                    MenuItem itemCategory = new MenuItem(
                        row["CategoryName"].ToString(),
                        row["CategoryID"].ToString());

                    Menu1.Items.Add(itemCategory);

                    // Получить дочерние элементы (товары) для данного
                    // родительского элемента (категории)
                    DataRow[] childRows = row.GetChildRows(ds.Relations[0]);

                    // Циклический проход no всем товарам данной категории
                    foreach (DataRow childRow in childRows)
                    {
                        MenuItem itemProduct = new MenuItem(
                            childRow["ProductName"].ToString(),
                            childRow["ProductID"].ToString());

                        itemCategory.ChildItems.Add(itemProduct);
                    }
                }
            }
        }

        private DataSet GetProductsAndCategories()
        {
            string connectionString =
            WebConfigurationManager.ConnectionStrings["Northwind"].ToString();

            SqlConnection connection = new SqlConnection(connectionString);
            string sqlCat = "SELECT CategoryID, CategoryName FROM Categories";
            string sqlProd = "SELECT ProductID, ProductName, CategoryID FROM Products";

            SqlDataAdapter da = new SqlDataAdapter(sqlCat, connection);
            DataSet ds = new DataSet();
            try
            {
                connection.Open();

                // Заполнить DataSet
                da.Fill(ds, "Categories");

                // Добавить таблицу products
                da.SelectCommand.CommandText = sqlProd;
                da.Fill(ds, "Products");
            }
            finally
            {
                connection.Close();
            }

            // Добавить отношение между Categories и Products
            DataRelation relat = new DataRelation("CatProds",
              ds.Tables["Categories"].Columns["CategoryID"],
              ds.Tables["Products"].Columns["CategoryID"]);

            ds.Relations.Add(relat);
            return ds;
        }

        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {
            if (Menu1.SelectedItem.Depth == 0)
                Label1.Text = "Вы выбрали категорию с CategoryID: ";
            else
                Label1.Text = "Вы выбрали товар с ProductID: ";

            Label1.Text += "" + Menu1.SelectedItem.Value + "";
        }
    }
}