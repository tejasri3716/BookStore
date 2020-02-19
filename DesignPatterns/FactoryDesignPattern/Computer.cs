//--------------------------------------------------------------------------------------------------------------------
// <copyright file="Computer.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.FactoryDesignPattern
{
    /// <summary>
    /// Interface Computer consists of abstract methods
    /// </summary>
    interface Computer
    {
        /// <summary>
        /// Gets the ram.
        /// </summary>
        /// <returns></returns>
        string getRAM();
        /// <summary>
        /// Gets the HDD.
        /// </summary>
        /// <returns></returns>
        string getHDD();
        /// <summary>
        /// Gets the cpu.
        /// </summary>
        /// <returns></returns>
        string getCPU();
    }
}
