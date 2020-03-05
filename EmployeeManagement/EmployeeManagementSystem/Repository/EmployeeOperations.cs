using EmployeeManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Repository
{
    public class EmployeeOperations : IEmployee
    {
        string conn = (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EmployeeDB;Integrated Security=True");
        public string AddEmployee(Employee employee)
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("AddEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@FirstName", employee.FirstName);
                cmd.Parameters.AddWithValue("@LastName", employee.LastName);
                cmd.Parameters.AddWithValue("@Email", employee.Email);
                cmd.Parameters.AddWithValue("@Password", employee.Password);
                con.Open();
                var result = cmd.ExecuteNonQuery();
                con.Close();
                return "Added";
            }
        }
        public string DeleteEmployee(string Email)
        {
            using (SqlConnection con = new SqlConnection(conn))
            {

                SqlCommand cmd = new SqlCommand("DeleteEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Email", Email);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return "Deleted";
            }
        }
        public List<Employee> GetEmployees()
        {
            List<Employee> list = new List<Employee>();
            using (SqlConnection con = new SqlConnection(this.conn))
            {
                SqlCommand cmd = new SqlCommand("GetAllEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader data = cmd.ExecuteReader();
                while (data.Read())
                {
                    Employee employee = new Employee();
                    employee.FirstName = data["FirstName"].ToString();
                    employee.LastName = data["LastName"].ToString();
                    employee.Email = data["Email"].ToString();
                    employee.Password = data["Password"].ToString();
                    list.Add(employee);
                }
                con.Close();
            }
            return list;
        }
        public bool LoginEmployee(string email, string password)
        {
            using (SqlConnection con = new SqlConnection(this.conn))
            {
                SqlCommand cmd = new SqlCommand("LoginEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);
                con.Open();
                DataSet dataSet = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataSet);
                con.Close();
                bool loginSuccessful = ((dataSet.Tables.Count > 0) && (dataSet.Tables[0].Rows.Count > 0));

                if (loginSuccessful && email != "" && password != "")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public string UpdateEmployee(Employee employee)
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                var emp = employee;
                SqlCommand cmd = new SqlCommand("UpdateEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@FirstName", employee.FirstName);
                cmd.Parameters.AddWithValue("@LastName", employee.LastName);
                cmd.Parameters.AddWithValue("@Email", employee.Email);
                cmd.Parameters.AddWithValue("@Password", employee.Password);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();
                return "Updated";
            }
        }
    }
}