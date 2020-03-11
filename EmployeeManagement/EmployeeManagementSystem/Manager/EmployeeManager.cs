// --------------------------------------------------------------------------------------------------------------------
// <copyright file=DeckOfCardsUsingQ.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace EmployeeManagementSystem.Manager
{
    using EmployeeManagementSystem.Model;
    using EmployeeManagementSystem.Repository;
    using System.Collections.Generic;

    /// <summary>
    /// EmployeeManager class implements IEmployeeManager
    /// </summary>
    /// <seealso cref="EmployeeManagement.EmployeeManager.IEmployeeManager" />
    public class EmployeeManager : IEmployeeManager
    {
        /// <summary>
        /// The repository
        /// </summary>
        private IEmployee repository = new EmployeeOperations();

        /// <summary>
        /// Gets this instance.
        /// </summary>
        /// <returns>
        /// Returns a list of all employees.
        /// </returns>
        public List<Employee> GetEmployees()
        {
            return this.repository.GetEmployees();
        }

        /// <summary>
        /// Adds the specified employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        public string AddEmployee(Employee employee)
        {
            var result = this.repository.AddEmployee(employee);
            return result;
        }

        /// <summary>
        /// Updates the specified employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        public string UpdateEmployee(Employee employee)
        {
            var result=this.repository.UpdateEmployee(employee);
            return result;
        }

        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public string DeleteEmployee(string email)
        {
            var result= this.repository.DeleteEmployee(email);
            return result;
        }

        /// <summary>
        /// Logins the specified email.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="password">The password.</param>
        /// <returns>
        /// Returns true if email and password exist else false.
        /// </returns>
        public bool LoginEmployee(string email, string password)
        {
            return this.repository.LoginEmployee(email, password);
        }
    }
}