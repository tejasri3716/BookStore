// --------------------------------------------------------------------------------------------------------------------
// <copyright file=DeckOfCardsUsingQ.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace EmployeeManagementTestCases
{
    using EmployeeManagementSystem.Manager;
    using NUnit.Framework;
    using EmployeeManagementSystem.Model;

    /// <summary>
    /// Tests class is used to Test the methods of Employee Management System
    /// </summary>
    [TestFixture]
    public class EmployeeManagementTest
    {
        /// <summary>
        /// Tests add method of EmployeeManager class
        /// </summary>
        [Test]
        public void TestAdd()
        {
            EmployeeManager manager = new EmployeeManager();
            Employee employee = new Employee()
            {
                FirstName = "absdfrgdfc",
                LastName = "cddf",
                Email = "bfaed@gmail.com",
                Password = "11114323"
            };
            var result = manager.AddEmployee(employee);
            Assert.AreEqual("Added", result);
        }

        /// <summary>
        /// Tests delete method of EmployeeManager class
        /// </summary>
        [Test]
        public void TestDelete()
        {
            EmployeeManager manager = new EmployeeManager();
            string email = "vcgh@gmail.com";
            var result = manager.DeleteEmployee(email);
            Assert.AreEqual("Deleted", result);
        }

        /// <summary>
        /// Tests update method of EmployeeManager class
        /// </summary>
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

        /// <summary>
        /// Tests login method of EmployeeManager class
        /// </summary>
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