//--------------------------------------------------------------------------------------------------------------------
// <copyright file="PrototypeTest.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryDesignPattern
{
    class FactoryTest
    {
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
