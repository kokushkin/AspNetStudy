using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;

namespace _6_6_Lib
{
    public class EmployeeDB
    {
        private string connectionString;

        public EmployeeDB()
        {
            // Получить строку соединения из web.config
            connectionString = WebConfigurationManager.ConnectionStrings["NorthwndConnectionString"].ConnectionString;
        }
        public EmployeeDB(string connectionString)
        {
            // Установить указанную строку соединения
            this.connectionString = connectionString;
        }

        public int InsertEmployee(EmployeeDetails emp)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("InsertEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@FirstName", SqlDbType.NVarChar, 10));
            cmd.Parameters["@FirstName"].Value = emp.FirstName;
            cmd.Parameters.Add(new SqlParameter("@LastName", SqlDbType.NVarChar, 20));
            cmd.Parameters["@LastName"].Value = emp.LastName;
            cmd.Parameters.Add(new SqlParameter("@BirthDate", SqlDbType.DateTime));
            cmd.Parameters["@BirthDate"].Value = emp.BirthDate;
            cmd.Parameters.Add(new SqlParameter("@EmployeeID", SqlDbType.Int, 4));
            cmd.Parameters["@EmployeeID"].Direction = ParameterDirection.Output;

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                return (int)cmd.Parameters["@EmployeeID"].Value;
            }
            catch (SqlException)
            {
                // Замените эту ошибку чем-то более специфичным. 
                // Здесь также можно протоколировать ошибки
                throw new ApplicationException("Ошибка данных");
            }
            finally
            {
                con.Close();
            }
        }

        public void UpdateEmployee(EmployeeDetails emp)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("UpdateEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@FirstName", SqlDbType.NVarChar, 10));
            cmd.Parameters["@FirstName"].Value = emp.FirstName;
            cmd.Parameters.Add(new SqlParameter("@LastName", SqlDbType.NVarChar, 20));
            cmd.Parameters["@LastName"].Value = emp.LastName;
            cmd.Parameters.Add(new SqlParameter("@EmployeeID", SqlDbType.Int, 4));
            cmd.Parameters["@EmployeeID"].Value = emp.EmployeeID;

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                throw new ApplicationException("Ошибка данных");
            }
            finally
            {
                con.Close();
            }
        }

        public void UpdateEmployee(int EmployeeID, string firstName, string lastName)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("UpdateEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@FirstName", SqlDbType.NVarChar, 10));
            cmd.Parameters["@FirstName"].Value = firstName;
            cmd.Parameters.Add(new SqlParameter("@LastName", SqlDbType.NVarChar, 20));
            cmd.Parameters["@LastName"].Value = lastName;
            cmd.Parameters.Add(new SqlParameter("@EmployeeID", SqlDbType.Int, 4));
            cmd.Parameters["@EmployeeID"].Value = EmployeeID;

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                throw new ApplicationException("Ошибка данных");
            }
            finally
            {
                con.Close();
            }
        }

        public void DeleteEmployee(int employeeID)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("DeleteEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@EmployeeID", SqlDbType.Int, 4));
            cmd.Parameters["@EmployeeID"].Value = employeeID;

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                throw new ApplicationException("Ошибка данных");
            }
            finally
            {
                con.Close();
            }
        }

        public EmployeeDetails GetEmployee(int employeeID)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("GetEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@EmployeeID", SqlDbType.Int, 4));
            cmd.Parameters["@EmployeeID"].Value = employeeID;

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);

                // Получить новую строку
                reader.Read();
                EmployeeDetails emp = new EmployeeDetails(
                    (int)reader["EmployeeID"], (string)reader["FirstName"],
                    (string)reader["LastName"], (DateTime)reader["BirthDate"]);
                reader.Close();
                return emp;
            }
            catch (SqlException)
            {
                throw new ApplicationException("Ошибка данных");
            }
            finally
            {
                con.Close();
            }
        }

        public List<EmployeeDetails> GetEmployees()
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("GetAllEmployees", con);
            cmd.CommandType = CommandType.StoredProcedure;

            // Создать коллекцию для всех записей о сотрудниках
            List<EmployeeDetails> employees = new List<EmployeeDetails>();

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    EmployeeDetails emp = new EmployeeDetails(
                        (int)reader["EmployeeID"], (string)reader["FirstName"],
                        (string)reader["LastName"], (DateTime)reader["BirthDate"]);
                    employees.Add(emp);
                }
                reader.Close();

                return employees;
            }
            catch (SqlException)
            {
                throw new ApplicationException("Ошибка данных");
            }
            finally
            {
                con.Close();
            }
        }

        public int CountEmployees()
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("CountEmployees", con);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                con.Open();
                return (int)cmd.ExecuteScalar();
            }
            catch (SqlException)
            {
                throw new ApplicationException("Ошибка данных");
            }
            finally
            {
                con.Close();
            }
        }
    }
}
