using EmployeeManagementSystem.Manager;
using EmployeeManagementSystem.Controller;
using NUnit.Framework;
using Microsoft.AspNetCore.Mvc;
using EmployeeManagementSystem.Model;

namespace EmployeeManagementTestCases
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestAdd()
        {
            EmployeeManager manager = new EmployeeManager();
            Employee employee = new Employee() { 
                FirstName = "abc",
                LastName = "cd",
                Email = "abcd@gmail.com",
                Password = "111123"
            };
            var result = manager.AddEmployee(employee);
            Assert.AreEqual("Added", result);
        }

        [Test]
        public void TestDelete()
        {
            EmployeeManager manager = new EmployeeManager();
            string email = "vcgh@gmail.com";
            var result = manager.DeleteEmployee(email);
            Assert.AreEqual("Deleted", result);
        }

        [Test]
        public void TestUpdate()
        {
            EmployeeManager manager = new EmployeeManager();
            Employee employee = new Employee()
            {
                FirstName = "aade",
                LastName = "ades",
                Email = "aa@gmail.com",
                Password = "12335"
            };
            var result = manager.UpdateEmployee(employee);
            Assert.AreEqual("Updated", result);
        }

        [Test]
        public void TestLogin()
        {
            EmployeeManager manager = new EmployeeManager();
            string email = "indrani@gmail.com";
            string password = "indu@3716";
            var result = manager.LoginEmployee(email, password);
            Assert.AreEqual("True", result.ToString());

        }
    }
}