// --------------------------------------------------------------------------------------------------------------------
// <copyright file=EmployeeController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace EmployeeManagementSystem.Controller
{
    using EmployeeManagementSystem.Manager;
    using EmployeeManagementSystem.Model;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Employee Controller class extends Controller Base wtihout view support
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    public class EmployeeController : ControllerBase
    {
        /// <summary>
        /// The manager
        /// </summary>
        public readonly IEmployeeManager manager;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeController"/> class.
        /// </summary>
        /// <param name="manager">The manager.</param>
        public EmployeeController(IEmployeeManager manager)
        {
            this.manager = manager;
        }

        /// <summary>
        /// Adds the employees.
        /// </summary>
        /// <param name="fname">The fname.</param>
        /// <param name="lname">The lname.</param>
        /// <param name="email">The email.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/add")]
        public ActionResult AddEmployees(string fname, string lname, string email, string password)
        {
            try
            {
                Employee employee = new Employee();

                employee.FirstName = fname;
                employee.LastName = lname;
                employee.Email = email;
                employee.Password = password;
                var result = this.manager.AddEmployee(employee);
                return this.Ok(result);
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Updates the employees.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns></returns>
        [HttpPut]
        [Route("api/update")]
        public ActionResult UpdateEmployees(Employee employee)
        {
            try
            {
                this.manager.UpdateEmployee(employee);
                return this.Ok(employee);
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Deletes the employee.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        [HttpDelete]
        [Route("api/delete")]
        public ActionResult DeleteEmployee(string email)
        {
            try
            {
                this.manager.DeleteEmployee(email);
                return this.Ok(email);
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Gets the employees.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/get")]
        public ActionResult GetEmployees()
        {
            try
            {
                IEnumerable<Employee> list = this.manager.GetEmployees();
                return this.Ok(list);
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Logins the employee.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/login")]
        public ActionResult LoginEmployee(string email, string password)
        {
            try
            {
                bool result = this.manager.LoginEmployee(email, password);
                if (result)
                {
                    return this.Ok(result);
                }
                else
                {
                    return this.BadRequest("Unrecognized EmailId and Password,Register First");
                }
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
    }
}