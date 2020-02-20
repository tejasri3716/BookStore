//--------------------------------------------------------------------------------------------------------------------
// <copyright file="IComputer.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.FactoryDesignPattern
{
    /// <summary>
    /// Interface Computer consists of abstract methods
    /// </summary>
    public interface IComputer
    {
        /// <summary>
        /// Gets the RAM.
        /// </summary>
        /// <returns>
        /// gets RAM
        /// </returns>
        string GetRAM();

        /// <summary>
        /// Gets the HDD.
        /// </summary>
        /// <returns>
        /// gets HDD
        /// </returns>
        string GetHDD();

        /// <summary>
        /// Gets the CPU.
        /// </summary>
        /// <returns>
        /// gets CPU
        /// </returns>
        string GetCPU();
    }
}
