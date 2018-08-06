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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DataTable dtCategories = GetCategories();

                // Изначально заполнить только категории
                foreach (DataRow row in dtCategories.Rows)
                {
                    TreeNode nodeCategory = new TreeNode(
                        row["CategoryName"].ToString(),
                        row["CategoryID"].ToString());

                    // Использовать средство заполнения no запросу 
                    // для дочерних узлов этого узла
                    nodeCategory.PopulateOnDemand = true;

                    nodeCategory.Collapse();
                    TreeView1.Nodes.Add(nodeCategory);
                }
            }
        }

        // Вспомогательный метод извлекающий только категории
        private DataTable GetCategories()
        {
            string connectionString =
                WebConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);

            string sqlCat = "SELECT CategoryID, CategoryName FROM Categories";

            SqlDataAdapter da = new SqlDataAdapter(sqlCat, con);
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                da.Fill(ds, "Categories");
            }
            finally
            {
                con.Close();
            }

            return ds.Tables["Categories"];
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

        protected void TreeView1_TreeNodePopulate(object sender, TreeNodeEventArgs e)
        {
            int categoryID = Int32.Parse(e.Node.Value);
            DataTable dtProducts = GetProducts(categoryID);

            foreach (DataRow row in dtProducts.Rows)
            {
                TreeNode nodeProduct = new TreeNode(
                    row["ProductName"].ToString(),
                    row["ProductID"].ToString());

                e.Node.ChildNodes.Add(nodeProduct);
            }
        }

        // Вспомогательный метод извлекающий продукты из
        // таблицы Products по CategoryID
        private DataTable GetProducts(int categoryID)
        {
            string connectionString =
                WebConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);

            string sqlProd = "SELECT ProductID, ProductName, CategoryID FROM Products WHERE CategoryID=@CategoryID";

            SqlDataAdapter da = new SqlDataAdapter(sqlProd, con);
            da.SelectCommand.Parameters.AddWithValue("@CategoryID", categoryID);
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                da.Fill(ds, "Products");
            }
            finally
            {
                con.Close();
            }
            return ds.Tables["Products"];
        }
    }
}