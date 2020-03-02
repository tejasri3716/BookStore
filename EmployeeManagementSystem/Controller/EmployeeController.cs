namespace EmployeeManagementSystem.Controller
{
    using EmployeeManagementSystem.Manager;
    using EmployeeManagementSystem.Model;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class EmployeeController : ControllerBase
    {
        public readonly IEmployeeManager manager;
        public EmployeeController(IEmployeeManager manager)
        {
            this.manager = manager;  
        }

        [HttpPost]
        [Route("api/add")]
        public ActionResult AddEmployees(string fname,string lname,string email, string password)
        {
            try
            {
                Employee employee = new Employee();

                employee.FirstName = fname;
                employee.LastName = lname;
                employee.Email = email;
                employee.Password = password;
                this.manager.AddEmployee(employee);
                return this.Ok(employee);
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }

        [HttpPut]
        [Route("api/update")]
        public ActionResult UpdateEmployees([FromBody]Employee employee)
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

        [HttpDelete]
        [Route("api/delete")]
        public ActionResult DeleteEmployee(string email)
        {
            try
            {
                this.manager.DeleteEmployee(email);
                return this.Ok(email);
            }
            catch(Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("api/get")]
        public ActionResult GetEmployees()
        {
            try
            {
                IEnumerable<Employee> list = this.manager.GetEmployees();
                return this.Ok(list);
            }
            catch(Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("api/login")]
        public ActionResult LoginEmployee(string email, string password)
        {
            try
            {
                bool result = this.manager.LoginEmployee(email, password);
                return this.Ok(result);
            }
            catch(Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }



    }
}
