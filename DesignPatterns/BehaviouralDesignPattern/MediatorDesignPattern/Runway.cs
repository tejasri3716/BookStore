//--------------------------------------------------------------------------------------------------------------------
// <copyright file="Runway.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.BehaviouralDesignPattern.MediatorDesignPattern
{
    using System;

    public class Runway : ICommand
    {
        private IATCMediator aTCMediator;
        public Runway(IATCMediator aTCMediator)
        {
            this.aTCMediator = aTCMediator;
            aTCMediator.SetLandingStatus(true);
        }
        public void Land()
        {
            Console.WriteLine("Landing permission granted");
            aTCMediator.SetLandingStatus(true);
        }
    }
}
