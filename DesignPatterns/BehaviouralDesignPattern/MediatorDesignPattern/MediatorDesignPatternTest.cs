//--------------------------------------------------------------------------------------------------------------------
// <copyright file="MediatorDesignPatternTest.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.BehaviouralDesignPattern.MediatorDesignPattern
{
    public class MediatorDesignPatternTest
    {
        public static void Test()
        {
            IATCMediator aTCMediator= new ATCMediator();
            Flight airAsia = new Flight(aTCMediator);
            Runway runway = new Runway(aTCMediator);
            aTCMediator.RegisterFlight(airAsia);
            airAsia.GetReady();
            runway.Land();
            airAsia.Land();
        }
    }
}