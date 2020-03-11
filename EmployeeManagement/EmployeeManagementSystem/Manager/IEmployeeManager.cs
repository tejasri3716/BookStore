// --------------------------------------------------------------------------------------------------------------------
// <copyright file=IEmployeeManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace EmployeeManagementSystem.Manager
{
    using EmployeeManagementSystem.Model;
    using System.Collections.Generic;

    /// <summary>
    /// Interface class IEmployeeManager
    /// </summary>
    /// <summary>
    public interface IEmployeeManager
    {
        /// Gets the employees.
        /// </summary>
        /// <returns>
        /// Gets all Emloyees
        /// </returns>
        List<Employee> GetEmployees();

        /// <summary>
        /// Adds the specified employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        string AddEmployee(Employee employee);

        /// <summary>
        /// Updates the specified employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        string UpdateEmployee(Employee employee);

        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        string DeleteEmployee(string Email);

        /// <summary>
        /// Logins the employee.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="password">The password.</param>
        /// <returns>
        /// Returns true if email and password exist else false.
        /// </returns>
        bool LoginEmployee(string email, string password);
    }
}