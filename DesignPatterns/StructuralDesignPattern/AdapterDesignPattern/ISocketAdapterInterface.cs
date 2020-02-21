//--------------------------------------------------------------------------------------------------------------------
// <copyright file="ISocketAdapterInterface.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.AdapterDesignPattern
{
    /// <summary>
    /// Interface for socket and adapter
    /// </summary>
    public interface ISocketAdapterInterface
    {
        /// <summary>
        /// Get 120 volts.
        /// </summary>
        /// <returns>method for getting 120 volts</returns>
        public Volt Get120Volts();

        /// <summary>
        /// Get 12 volts.
        /// </summary>
        /// <returns>method for getting 12 volts</returns>
        public Volt Get12Volts();

        /// <summary>
        /// Get 3 volts.
        /// </summary>
        /// <returns>method for getting 3 volts</returns>
        public Volt Get3Volts();
    }
}
