//--------------------------------------------------------------------------------------------------------------------
// <copyright file="FactoryTest.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.FactoryDesignPattern
{
    using System;
    /// <summary>
    /// Factory Test class is used to test  the Factory Design Pattern
    /// </summary>
    class FactoryTest
    {
        /// <summary>
        /// Tests the Factory Design Pattern
        /// </summary>
        public static void Test()
        {
            Console.WriteLine("enter your object type");
            string type = Utility.ReadString();
            Computer computer = ComputerFactory.GetComputerObject(type);
            Console.WriteLine("RAM of "+ type + " is " +computer.getRAM());
            Console.WriteLine("HDD of " + type + " is " + computer.getHDD());
            Console.WriteLine("CPU of " + type + " is " + computer.getCPU());

        }
    }
}
