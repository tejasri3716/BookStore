//--------------------------------------------------------------------------------------------------------------------
// <copyright file="Flight.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.BehaviouralDesignPattern.MediatorDesignPattern
{
    using System;

    public class Flight : ICommand
    {
        private IATCMediator aTCMediator;
        public Flight(IATCMediator aTCMediator)
        {
            this.aTCMediator = aTCMediator;
        }
        public void Land()
        {
            if(aTCMediator.IsLandingOk())
            {
                Console.WriteLine("Successfully landed");
                aTCMediator.SetLandingStatus(true);
            }
            else
            {
                Console.WriteLine("waiting for landing");
            }
        }
        public void GetReady()
        {
            Console.WriteLine("Ready for landing");
        }
    }
}
