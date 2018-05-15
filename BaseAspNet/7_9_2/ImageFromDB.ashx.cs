using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace _7_9_2
{
    /// <summary>
    /// Summary description for ImageFromDB
    /// </summary>
    public class ImageFromDB : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            //context.Response.ContentType = "text/plain";
            //context.Response.Write("Hello World");

            string connectionString =
                WebConfigurationManager.ConnectionStrings["Pubs"].ConnectionString;

            // Получить GET-идентификатор для данного запроса
            string id = context.Request.QueryString["id"];
            if (id == null) throw new ApplicationException("Должен быть указан идентификатор");

            // Создать параметризованную команду для данной записи
            SqlConnection con = new SqlConnection(connectionString);
            string SQL = "SELECT logo FROM pub_info WHERE pub_id=@ID";
            SqlCommand cmd = new SqlCommand(SQL, con);
            cmd.Parameters.AddWithValue("@ID", id);

            try
            {
                con.Open();
                SqlDataReader r =
                  cmd.ExecuteReader(CommandBehavior.SequentialAccess);

                if (r.Read())
                {
                    int bufferSize = 100;                   // Размер буфера
                    byte[] bytes = new byte[bufferSize];    // Буфер
                    long bytesRead;                         // Прочитано байт
                    long readFrom = 0;                      // Начальный индекс

                    // Читать поле по 100 байт за раз
                    do
                    {
                        bytesRead = r.GetBytes(0, readFrom, bytes, 0, bufferSize);
                        context.Response.BinaryWrite(bytes);
                        readFrom += bufferSize;
                    } while (bytesRead == bufferSize);
                }
                r.Close();
            }
            finally
            {
                con.Close();
            }
        }

        public bool IsReusable
        {
            get
            {
                return true;
            }
        }
    }
}