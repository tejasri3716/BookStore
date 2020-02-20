//--------------------------------------------------------------------------------------------------------------------
// <copyright file="SocketAdapterImplementation.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.AdapterDesignPattern
{
    /// <summary>
    /// SocketAdapterImplementation class implements SocketAdapterInterface interface
    /// </summary>
    /// <seealso cref="DesignPatterns.AdapterDesignPattern.SocketAdapterInterface" />
    class SocketAdapterImplementation : SocketAdapterInterface
    {
        Socket socket = new Socket();

        /// <summary>
        /// Get 120 volts.
        /// </summary>
        /// <returns>gets 120 volts</returns>
        public Volt Get120Volts()
        {
          return socket.GetVolt();
        }

        /// <summary>
        /// Get 12 volts.
        /// </summary>
        /// <returns>gets 12 volts</returns>
        public Volt Get12Volts()
        {
            Volt volt = socket.GetVolt();
            return ConvertVolts(volt, 10);
        }

        /// <summary>
        /// Get 3 volts.
        /// </summary>
        /// <returns>gets 3 volts</returns>
        public Volt Get3Volts()
        {
            Volt volt = socket.GetVolt();
            return ConvertVolts(volt, 40);
        }

        /// <summary>
        /// Converts the volts.
        /// </summary>
        /// <param name="volt">The volt.</param>
        /// <param name="i">The i.</param>
        /// <returns></returns>
        public Volt ConvertVolts(Volt volt, int i)
        {
            return new Volt(volt.GetVolts() / i);
        }
    }
}
