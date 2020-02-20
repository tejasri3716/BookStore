//--------------------------------------------------------------------------------------------------------------------
// <copyright file="Volt.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.AdapterDesignPattern
{
    /// <summary>
    /// Volt class consisting of get volt method
    /// </summary>
    public class Volt
    {
        /// <summary>
        /// The volts
        /// </summary>
        private int volts;

        /// <summary>
        /// Initializes a new instance of the <see cref="Volt"/> class.
        /// </summary>
        public Volt()
        {
            this.volts = 120;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Volt"/> class.
        /// </summary>
        /// <param name="v">The v.</param>
        public Volt(int v)
        {
            this.volts = v;
        }

        /// <summary>
        /// Gets the volts.
        /// </summary>
        /// <returns>
        /// volts
        /// </returns>
        public int GetVolts()
        {
            return this.volts;
        }

        /// <summary>
        /// Sets the volts.
        /// </summary>
        /// <param name="volts">The volts.</param>
        public void SetVolts(int volts)
        {
            this.volts = volts;
        }
    }
}