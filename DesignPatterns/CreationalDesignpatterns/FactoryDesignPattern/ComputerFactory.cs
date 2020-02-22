//--------------------------------------------------------------------------------------------------------------------
// <copyright file="ComputerFactory.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.FactoryDesignPattern
{
    using System;
    /// <summary>
    /// Computer Factory Class is used as to hide implementation details from the client
    /// </summary>
    public class ComputerFactory
    {
        /// <summary>
        /// Gets the computer object.
        /// </summary>
        /// <param name="typeOfObj">The type of object.</param>
        /// <returns>
        /// gets Computer Object
        /// </returns>
        public static IComputer GetComputerObject(string typeOfObj)
        {

            IComputer obj = null;
            if (typeOfObj.ToLower() == "pc")
            {
                Console.WriteLine("enter RAM,HDD,CPU values for Pc");
                string ram = Utility.ReadString();
                string hdd = Utility.ReadString();
                string cpu = Utility.ReadString();
                obj = new PC(ram, hdd, cpu);
            }
            else
            {
                Console.WriteLine("enter RAM,HDD,CPU values for Server");
                string ram = Utility.ReadString();
                string hdd = Utility.ReadString();
                string cpu = Utility.ReadString();
                obj = new Server(ram, hdd, cpu);
            }

            return obj;
        }
    }
}
