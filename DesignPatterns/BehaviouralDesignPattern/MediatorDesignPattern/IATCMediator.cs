//--------------------------------------------------------------------------------------------------------------------
// <copyright file="IATCMediator.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.BehaviouralDesignPattern.MediatorDesignPattern
{
    /// <summary>
    /// IATCMediator interface consists of abstract methods to set landing status
    /// to register the runway for landing 
    /// to register the flight
    /// to check whether runway is free for landing or not
    /// </summary>
    public interface IATCMediator
    {
        /// <summary>
        /// Registers the runway.
        /// </summary>
        /// <param name="runway">The runway.</param>
        public void RegisterRunway(Runway runway);

        /// <summary>
        /// Registers the flight.
        /// </summary>
        /// <param name="flight">The flight.</param>
        public void RegisterFlight(Flight flight);

        /// <summary>
        /// Determines whether [is landing ok].
        /// </summary>
        /// <returns>
        ///   <c>true</c> if [is landing ok]; otherwise, <c>false</c>.
        /// </returns>
        public bool IsLandingOk();

        /// <summary>
        /// Sets the landing status.
        /// </summary>
        /// <param name="status">if set to <c>true</c> [status].</param>
        public void SetLandingStatus(bool status);
    }
}