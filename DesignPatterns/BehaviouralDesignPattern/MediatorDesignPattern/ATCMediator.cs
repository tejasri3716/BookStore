//--------------------------------------------------------------------------------------------------------------------
// <copyright file="ATCMediator.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.BehaviouralDesignPattern.MediatorDesignPattern
{
    /// <summary>
    /// ATCMediator class is used check the air traffic and sends the flight to land if runway is free
    /// </summary>
    /// <seealso cref="DesignPatterns.BehaviouralDesignPattern.MediatorDesignPattern.IATCMediator" />
    public class ATCMediator : IATCMediator
    {
        /// <summary>
        /// The land
        /// </summary>
        private bool land;

        /// <summary>
        /// The flight
        /// </summary>
        private Flight flight;

        /// <summary>
        /// The runway
        /// </summary>
        private Runway runway;

        /// <summary>
        /// Registers the runway.
        /// </summary>
        /// <param name="runway">The runway.</param>
        public void RegisterRunway(Runway runway)
        {
            this.runway = runway;
        }

        /// <summary>
        /// Registers the flight.
        /// </summary>
        /// <param name="flight">The flight.</param>
        public void RegisterFlight(Flight flight)
        {
            this.flight = flight;
        }

        /// <summary>
        /// Determines whether [is landing ok].
        /// </summary>
        /// <returns>
        ///   <c>true</c> if [is landing ok]; otherwise, <c>false</c>.
        /// </returns>
        public bool IsLandingOk()
        {
            return this.land;
        }

        /// <summary>
        /// Sets the landing status.
        /// </summary>
        /// <param name="status">if set to <c>true</c> [status].</param>
        public void SetLandingStatus(bool status)
        {
            this.land = status;
        }
    }
}