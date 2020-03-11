// --------------------------------------------------------------------------------------------------------------------
// <copyright file=DeckOfCardsUsingQ.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace EmployeeManagementSystem.Repository
{
    using EmployeeManagementSystem.Model;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;

    /// <summary>
    /// Employee Operations class implements IEmployee interface
    /// </summary>
    public class EmployeeOperations : IEmployee
    {
        string conn = (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EmployeeDB;Integrated Security=True");

        /// <summary>
        /// Add Employee method retreivesw the data from database
        /// </summary>
        /// <param name="employee"></param>
        /// <returns>
        /// returns added if added successfully into database
        /// </returns>
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

        /// <summary>
        /// Delete Employee method deletes a particular employee details
        /// </summary>
        /// <param name="Email"></param>
        /// <returns>
        /// return deleted on successfull deletion
        /// </returns>
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

        /// <summary>
        /// Get Employees method is used to get the list of all employees in the database
        /// </summary>
        /// <returns> 
        /// returns the list of employees
        /// </returns>
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

        /// <summary>
        /// Login Employee method is used to check the credentials of the user
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns>
        /// returns true status on successfull login
        /// </returns>
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
                bool login = ((dataSet.Tables.Count > 0) && (dataSet.Tables[0].Rows.Count > 0));

                if (login && email != "" && password != "")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// Update Employee method is used to update the particular user details
        /// </summary>
        /// <param name="employee"></param>
        /// <returns>
        /// returns updated on successfull updation in the database
        /// </returns>
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