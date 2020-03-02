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
        void AddEmployee(Employee employee);
        void DeleteEmployee(string email);
        bool UpdateEmployee(Employee employee);
        bool LoginEmployee(string email, string password);
    }
}
