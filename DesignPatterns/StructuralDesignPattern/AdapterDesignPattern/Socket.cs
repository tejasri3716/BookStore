//--------------------------------------------------------------------------------------------------------------------
// <copyright file="Socket.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.AdapterDesignPattern
{
    /// <summary>
    /// Socket class containing a method to get volt
    /// </summary>
    public class Socket
    {
        /// <summary>
        /// Gets the volt.
        /// </summary>
        /// <returns>get volts</returns>
        public Volt GetVolt()
        {
            return new Volt();
        }
    }
}
