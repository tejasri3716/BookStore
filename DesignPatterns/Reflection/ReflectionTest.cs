//--------------------------------------------------------------------------------------------------------------------
// <copyright file="ReflectionTest.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.Reflection
{
    using System;
    using System.Reflection;

    /// <summary>
    /// ReflectionTest class is used to display the meta data about student class
    /// </summary>
    public class ReflectionTest
    {
        /// <summary>
        /// Tests this instance.
        /// </summary>
        public static void Test()
        {
            Type typing = Type.GetType("DesignPatterns.Reflection.Student");
            Console.WriteLine("Full Name : {0}", typing.FullName);
            Console.WriteLine("Class Name is : {0}", typing.Name);
            Console.WriteLine("Methods in the Class are ");
            MethodInfo[] methods = typing.GetMethods();
            foreach(var method in methods)
            {
                Console.WriteLine(method.ReturnType.Name + " " + method.Name);
            }

            Console.WriteLine("Properties in Customer Class");
            PropertyInfo[] properties = typing.GetProperties();

            ////Traversing the data present in the property object.
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType.Name + " " + property.Name);
            }
            Console.WriteLine("Constructors in Customer Class");
            ConstructorInfo[] constructors = typing.GetConstructors();
            foreach (var constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());
            }
            /*Assembly executing = Assembly.GetExecutingAssembly();
             Type[] types = executing.GetTypes();
             foreach (var item in types)
             {
                 // Display each type 
                 // Array to store methods 
                MethodInfo[] methods = item.GetMethods();
                 foreach (var method in methods)
                 {
                     // Display each method 
                     Console.WriteLine("--> Method : {0},Method Return type : {1}", method.Name,method.ReturnType);

                     // Array to store parameters 
                     ParameterInfo[] parameters = method.GetParameters();
                     foreach (var arg in parameters)
                     {
                         // Display each parameter 
                         Console.WriteLine("Parameter : {0} Type : {1}",arg.Name, arg.ParameterType);
                     }
                 }
             }*/
        }
    }
}