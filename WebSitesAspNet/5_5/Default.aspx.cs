using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _5_5
{
    public partial class Default : System.Web.UI.Page, ICallbackEventHandler
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string callbackRef = Page.ClientScript.GetCallbackEventReference(
                this, "document.getElementById('lstRegions').value", "ClientCallback", "null", true);

            lstRegions.Attributes["onChange"] = callbackRef;
        }

        protected void cmdOK_Click(object sender, EventArgs e)
        {
            // Код, не защищенный от атак SQL-инъекциями
            lblInfo.Text = "Вы выбрали регион с ID #" + Request.Form["lstTerritories"];

            // Сбросить список
            lstRegions.SelectedIndex = 0;
        }

        private string eventArgument;
        public void RaiseCallbackEvent(string eventArgument)
        {
            this.eventArgument = eventArgument;
        }

        public string GetCallbackResult()
        {
            // Создать объекты ADO.NET
            SqlConnection con = new SqlConnection(
                WebConfigurationManager.ConnectionStrings["Northwind"].ConnectionString);
            SqlCommand cmd = new SqlCommand(
                "SELECT * FROM Territories WHERE RegionID=@RegionID", con);
            cmd.Parameters.Add(new SqlParameter("@RegionID", SqlDbType.Int, 4));
            cmd.Parameters["@RegionID"].Value = Int32.Parse(eventArgument);

            // Создать объект StringBuilder, который содержит строку ответа
            StringBuilder results = new StringBuilder();
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                // Построить строку ответа
                while (reader.Read())
                {
                    results.Append(reader["TerritoryDescription"]);
                    results.Append("|");
                    results.Append(reader["TerritoryID"]);
                    results.Append("||");
                }
                reader.Close();
            }
            catch
            {
                // Скрыть ошибки подключения
            }
            finally
            {
                con.Close();
            }
            return results.ToString();
        }
    }
}