using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _6_2
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
            SqlCommand command = new SqlCommand("SELECT * FROM Employees", connection);
            string result = "";

            using (connection)
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                // Пройти в цикле по записям и построить HTML-строку
                while (reader.Read())
                {
                    result += String.Format("<li>{0} <b>{1}</b> {2} - работает с {3}</li>",
                        reader["TitleOfCourtesy"], reader.GetString(1), reader.GetString(2),
                        reader.GetDateTime(6).ToString("y"));
                }

                // Закрыть DataReader
                reader.Close();
            }

            // Вывести в Label1
            Label1.Text = "<h1>Данные сотрудников</h1>" + result;
        }
    }
}