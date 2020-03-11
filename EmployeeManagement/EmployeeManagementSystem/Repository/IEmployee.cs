// --------------------------------------------------------------------------------------------------------------------
// <copyright file=IEmployee.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace EmployeeManagementSystem.Repository
{
    using EmployeeManagementSystem.Model;
    using System.Collections.Generic;

    /// <summary>
    /// IEmployee interface consists of abstract methods
    /// </summary>
    public interface IEmployee
    {
        /// <summary>
        /// Gets the employees.
        /// </summary>
        /// <returns></returns>
        List<Employee> GetEmployees();

        /// <summary>
        /// Adds the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns></returns>
        string AddEmployee(Employee employee);

        /// <summary>
        /// Deletes the employee.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        string DeleteEmployee(string email);

        /// <summary>
        /// Updates the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns></returns>
        string UpdateEmployee(Employee employee);

        /// <summary>
        /// Logins the employee.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        bool LoginEmployee(string email, string password);
    }
}