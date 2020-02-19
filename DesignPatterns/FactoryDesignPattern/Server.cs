//--------------------------------------------------------------------------------------------------------------------
// <copyright file="Server.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.FactoryDesignPattern
{
    using System;
    /// <summary>
    /// Server class Implements Computer Class
    /// </summary>
    /// <seealso cref="DesignPatterns.FactoryDesignPattern.Computer" />
    class Server : Computer
    {
        private string ram;
        private string hdd;
        private string cpu;
        /// <summary>
        /// Initializes a new instance of the <see cref="Server"/> class.
        /// </summary>
        /// <param name="ram">The ram.</param>
        /// <param name="hdd">The HDD.</param>
        /// <param name="cpu">The cpu.</param>
        public Server(String ram, String hdd, String cpu)
        {
            this.ram = ram;
            this.hdd = hdd;
            this.cpu = cpu;
        }
        /// <summary>
        /// Gets the ram.
        /// </summary>
        /// <returns></returns>
        public string getRAM()
        {
            return this.ram;
        }
        /// <summary>
        /// Gets the HDD.
        /// </summary>
        /// <returns></returns>
        public string getHDD()
        {
            return this.hdd;
        }
        /// <summary>
        /// Gets the cpu.
        /// </summary>
        /// <returns></returns>
        public string getCPU()
        {
            return this.cpu;
        }
    }
}
