using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2_5_1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, System.EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                // Извлечь DataSet с помощью вспомогательного метода
                DataSet ds = GetProductsAndCategories();

                // Циклический проход по записям категорий
                foreach (DataRow row in ds.Tables["Categories"].Rows)
                {
                    // Использовать конструктор, который требует только текст 
                    // и неотображаемое значение
                    TreeNode nodeCategory = new TreeNode(
                        row["CategoryName"].ToString(),
                        row["CategoryID"].ToString());

                    TreeView1.Nodes.Add(nodeCategory);

                    // Получить дочерние элементы (товары) для данного
                    // родительского элемента (категории)
                    DataRow[] childRows = row.GetChildRows(ds.Relations[0]);

                    // Циклический проход no всем товарам данной категории
                    foreach (DataRow childRow in childRows)
                    {
                        TreeNode nodeProduct = new TreeNode(
                            childRow["ProductName"].ToString(),
                            childRow["ProductID"].ToString());
                        nodeCategory.ChildNodes.Add(nodeProduct);
                    }

                    // Сохранить свернутое состояние всех категорий
                    nodeCategory.Collapse();
                }
            }
        }

        // Вспомогательный метод, возвращающий DataSet для двух таблиц
        // Category и Products тестовой базы данных Northwind
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

        protected void TreeView1_SelectedNodeChanged(object sender, EventArgs e)
        {
            if (TreeView1.SelectedNode == null) return;
            if (TreeView1.SelectedNode.Depth == 0)
                Label1.Text = "Вы выбрали категорию с CategoryID: ";
            else
                Label1.Text = "Вы выбрали товар с ProductID: ";

            Label1.Text += "<b>" + TreeView1.SelectedNode.Value + "</b>";
        }
    }
}