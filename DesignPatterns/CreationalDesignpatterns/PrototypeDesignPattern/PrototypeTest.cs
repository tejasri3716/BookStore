//--------------------------------------------------------------------------------------------------------------------
// <copyright file="PrototypeTest.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.PrototypeDesignPattern
{
    using System;
    /// <summary>
    /// Prototype Test class is used to test whether object is cloned successfully or not
    /// </summary>
    class PrototypeTest
    {
        /// <summary>
        ///Test to execute all the operations
        /// </summary>
        public static void Test()
        {
            //// new Employee object creation 
            Employee emp = new Employee();

            ////input the name
            Console.Write("enter employee name : ");
            emp.SetName(Utility.ReadString());
            //// input the eid
            Console.Write("enter employee id : ");
            emp.SetEid(Utility.ReadInt());
            ////input the age
            Console.Write("enter employee age : ");
            emp.SetAge(Utility.ReadInt());

            //// print the details
            Console.WriteLine(emp.GetDetails());

            //// clone the Employee object
            Employee empobj = emp.Clone();

            //// imput employee name
            Console.Write("enter employee name : ");
            empobj.SetName(Utility.ReadString());

            //// input employee id
            Console.Write("enter employee id");
            empobj.SetEid(Utility.ReadInt());

            //// print the details
            Console.WriteLine(emp.GetDetails());
            Console.WriteLine(empobj.GetDetails());
        }
    }
}
