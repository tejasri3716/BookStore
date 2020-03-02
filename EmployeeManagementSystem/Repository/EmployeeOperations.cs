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
        public void AddEmployee(Employee employee)
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
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        public void DeleteEmployee(string Email)
        {
            using (SqlConnection con = new SqlConnection(conn))
            {

                SqlCommand cmd = new SqlCommand("DeleteEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Email", Email);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
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
                SqlCommand cmd = new SqlCommand("GetAllEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader data = cmd.ExecuteReader();
                while (data.Read())
                {
                    if (Equals(data["email"].ToString(), email))
                    {
                        if (Equals(data["password"].ToString(), password))
                        {
                            return true;
                        }
                    }
                }
                con.Close();
                return false;
            }
        }
        public bool UpdateEmployee(Employee employee)
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("UpdateEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@FirstName", employee.FirstName);
                cmd.Parameters.AddWithValue("@LastName", employee.LastName);
                cmd.Parameters.AddWithValue("@Email", employee.Email);
                cmd.Parameters.AddWithValue("@Password", employee.Password);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();

                if(i>=1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}