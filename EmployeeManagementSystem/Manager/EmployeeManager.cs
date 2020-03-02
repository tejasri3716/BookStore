

namespace EmployeeManagementSystem.Manager
{
    using EmployeeManagementSystem.Model;
    using EmployeeManagementSystem.Repository;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

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
        public void AddEmployee(Employee employee)
        {
            this.repository.AddEmployee(employee);
        }

        /// <summary>
        /// Updates the specified employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        public void UpdateEmployee(Employee employee)
        {
            this.repository.UpdateEmployee(employee);
        }

        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public void DeleteEmployee(string email)
        {
            this.repository.DeleteEmployee(email);
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
