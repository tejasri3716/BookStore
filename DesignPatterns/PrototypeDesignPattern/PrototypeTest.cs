using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.PrototypeDesignPattern
{
    class PrototypeTest
    {
            /// <summary>
            ///Test to execute all the operations
            /// </summary>
            public void Test()
            {
                //// new Employee object creation 
                Employee empobj1 = new Employee();

                ////input the name
                Console.Write("enter employee name : ");
                empobj1.SetName(Console.ReadLine());
                //// input the eid
                Console.Write("enter employee id : ");
                empobj1.SetEid(Convert.ToInt32(Console.ReadLine()));
                ////input the age
                Console.Write("enter employee age : ");
                empobj1.SetAge(Convert.ToInt32(Console.ReadLine()));

            //// print the details
            Console.WriteLine(empobj1.GetDetails());

                //// clone the Employee object
                Employee empobj2 = empobj1.Clone();

                //// imput employee name
                Console.Write("enter employee name : ");
                empobj1.SetName(Console.ReadLine());

                //// input employee salary
                Console.Write("enter employee salary");
                empobj1.SetSalary(Convert.ToInt32(Console.ReadLine()));

                ////print the details
                Console.WriteLine(empobj1.GetDetails());
                Console.WriteLine(empobj2.GetDetails());
            }
        }
    }
}
