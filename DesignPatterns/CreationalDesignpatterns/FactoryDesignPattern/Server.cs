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
    /// <seealso cref="DesignPatterns.FactoryDesignPattern.IComputer" />
    public class Server : IComputer
    {
        /// <summary>
        /// The ram
        /// </summary>
        private string ram;

        /// <summary>
        /// The HDD
        /// </summary>
        private string hdd;

        /// <summary>
        /// The cpu
        /// </summary>
        private string cpu;

        /// <summary>
        /// Initializes a new instance of the <see cref="Server"/> class.
        /// </summary>
        /// <param name="ram">The ram.</param>
        /// <param name="hdd">The HDD.</param>
        /// <param name="cpu">The cpu.</param>
        public Server(string ram, string hdd, string cpu)
        {
            this.ram = ram;
            this.hdd = hdd;
            this.cpu = cpu;
        }

        /// <summary>
        /// Gets the ram.
        /// </summary>
        /// <returns></returns>
        public string GetRAM()
        {
            return this.ram;
        }

        /// <summary>
        /// Gets the HDD.
        /// </summary>
        /// <returns></returns>
        public string GetHDD()
        {
            return this.hdd;
        }

        /// <summary>
        /// Gets the cpu.
        /// </summary>
        /// <returns></returns>
        public string GetCPU()
        {
            return this.cpu;
        }
    }
}