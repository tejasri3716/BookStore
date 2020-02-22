//--------------------------------------------------------------------------------------------------------------------
// <copyright file="MediatorDesignPatternTest.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.BehaviouralDesignPattern.MediatorDesignPattern
{
    /// <summary>
    /// MediatorDesignPatternTest class is used to send the landing status to flight 
    /// and in response receives landed status
    /// </summary>
    public class MediatorDesignPatternTest
    {
        /// <summary>
        /// Tests this instance.
        /// </summary>
        public static void Test()
        {
            IATCMediator atcMediator = new ATCMediator();
            Flight airAsia = new Flight(atcMediator);
            Runway runway = new Runway(atcMediator);
            atcMediator.RegisterFlight(airAsia);
            airAsia.GetReady();
            runway.Land();
            airAsia.Land();
        }
    }
}