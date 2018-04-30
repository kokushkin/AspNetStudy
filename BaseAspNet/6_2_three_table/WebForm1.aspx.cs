using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _6_2_three_table
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Создать объект Connection из строки подключения в файле web.config
            string connectionString =
                WebConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);

            // Создать команду
            SqlCommand command = new SqlCommand("SELECT TOP 5 * FROM Employees; " +
                "SELECT TOP 5 * FROM Customers; SELECT TOP 5 * FROM Suppliers; ", connection);
            string result = "";

            using (connection)
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                int i = 0;

                // Цикл по записям всех результирующих наборов с построением HTML-строки
                do
                {
                    i++;
                    result += "<h1>Таблица №" + i + "</h1>";

                    while (reader.Read())
                    {
                        result += "<li>";
                        // Получить все поля строки
                        for (int field = 0; field < reader.FieldCount; field++)
                        {
                            result += "<b>" + reader.GetName(field).ToString() + "</b>" + ": " +
                                reader.GetValue(field).ToString() + "<br>";
                        }
                        result += "</li>";
                    }
                }
                while (reader.NextResult());

                reader.Close();
            }

            // Вывести в Label1
            Label1.Text = result;
        }
    }
}