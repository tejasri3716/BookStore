//--------------------------------------------------------------------------------------------------------------------
// <copyright file="PC.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.FactoryDesignPattern
{
    /// <summary>
    /// PC class implements Computer class
    /// </summary>
    /// <seealso cref="DesignPatterns.FactoryDesignPattern.IComputer" />
   public class PC : IComputer
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
        /// Initializes a new instance of the <see cref="PC"/> class.
        /// </summary>
        /// <param name="ram">The ram.</param>
        /// <param name="hdd">The HDD.</param>
        /// <param name="cpu">The cpu.</param>
        public PC(string ram, string hdd, string cpu)
        {
            this.ram = ram;
            this.hdd = hdd;
            this.cpu = cpu;
        }

        /// <summary>
        /// Gets the RAM.
        /// </summary>
        /// <returns>
        /// gets RAM
        /// </returns>
        public string GetRAM()
        {
            return this.ram;
        }

        /// <summary>
        /// Gets the HDD.
        /// </summary>
        /// <returns>
        /// gets HDD
        /// </returns>
        public string GetHDD()
        {
            return this.hdd;
        }

        /// <summary>
        /// Gets the CPU.
        /// </summary>
        /// <returns>
        /// gets CPU
        /// </returns>
        public string GetCPU()
        {
            return this.cpu;
        }
    }
}