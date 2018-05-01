using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _6_3_Procedure
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = WebConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);

            // Создать команду для вызова хранимой процедуры InsertEmployee
            SqlCommand cmd = new SqlCommand("InsertEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;

            // Указать параметры
            cmd.Parameters.AddWithValue("@LastName", "Pupkin");
            cmd.Parameters.AddWithValue("@FirstName", "Vasiliy");

            // Последний параметр является выходным (output)
            cmd.Parameters.Add(new SqlParameter("@EmployeeID", SqlDbType.Int, 4));
            cmd.Parameters["@EmployeeID"].Direction = ParameterDirection.Output;

            con.Open();
            try
            {
                int numAff = cmd.ExecuteNonQuery();
                Label1.Text = String.Format("Добавлена <b>{0}</b> запись<br />", numAff);

                // Получить вновь сгенерированный идентификатор
                int empID = (int)cmd.Parameters["@EmployeeID"].Value;
                Label1.Text += "<br>Новому сотруднику присвоен ID: " + empID.ToString();
            }
            finally
            {
                con.Close();
            }
        }
    }
}