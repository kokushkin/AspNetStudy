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
            // Создать объект Connection из строки подключения в файле web.config
            string connectionString =
                ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;

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
        }
    }
}
