using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _6_3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void cmdGetRecords_Click(object sender, EventArgs e)
        {
            string connectionString = WebConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);

            //// Получить заказы по идентификатору заказчика
            //string sql =
            //    "SELECT Orders.CustomerID, Orders.OrderID, COUNT(UnitPrice) AS Items, " +
            //    "SUM(UnitPrice * Quantity) AS Total FROM Orders " +
            //    "INNER JOIN [Order Details] " +
            //    "ON Orders.OrderID = [Order Details].OrderID " +
            //    "WHERE Orders.CustomerID = '" + txtID.Text + "' " +
            //    "GROUP BY Orders.OrderID, Orders.CustomerID";

            string sql =
                "SELECT Orders.CustomerID, Orders.OrderID, COUNT(UnitPrice) AS Items, " +
                "SUM(UnitPrice * Quantity) AS Total FROM Orders " +
                "INNER JOIN [Order Details] " +
                "ON Orders.OrderID = [Order Details].OrderID " +
                "WHERE Orders.CustomerID = @CustID " +
                "GROUP BY Orders.OrderID, Orders.CustomerID";

            SqlCommand cmd = new SqlCommand(sql, con);

            //cmd.Parameters.Add("@CustID", txtID.Text);
            cmd.Parameters.AddWithValue("@CustID", txtID.Text);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            GridView1.DataSource = reader;
            GridView1.DataBind();
            reader.Close();
            con.Close();
        }
    }
}