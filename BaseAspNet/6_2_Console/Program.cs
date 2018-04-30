using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Создать объект Connection из строки подключения в файле web.config
            //string connectionString =
            //    ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;

            //SqlConnection connection = new SqlConnection(connectionString);

            //// Создать команду
            //SqlCommand command = new SqlCommand("SELECT * FROM Employees", connection);
            //string result = "";

            //using (connection)
            //{
            //    connection.Open();
            //    SqlDataReader reader = command.ExecuteReader();

            //    // Пройти в цикле по записям и построить HTML-строку
            //    while (reader.Read())
            //    {
            //        result += String.Format("<li>{0} <b>{1}</b> {2} - работает с {3}</li>",
            //            reader["TitleOfCourtesy"], reader.GetString(1), reader.GetString(2),
            //            reader.GetDateTime(6).ToString("y"));
            //    }

            //    // Закрыть DataReader
            //    reader.Close();
            //}




            string connectionString = ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;
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

            //cmd.Parameters.Add("@CustID", "ALFKI");
            cmd.Parameters.AddWithValue("@CustID", "ALFKI");

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            //GridView1.DataSource = reader;
            //GridView1.DataBind();
            reader.Close();
            con.Close();
        }
    }
}
