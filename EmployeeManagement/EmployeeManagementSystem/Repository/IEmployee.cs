using EmployeeManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Repository
{
    public interface IEmployee
    {
        List<Employee> GetEmployees();
        string AddEmployee(Employee employee);
        string DeleteEmployee(string email);
        string UpdateEmployee(Employee employee);
        bool LoginEmployee(string email, string password);
    }
}
