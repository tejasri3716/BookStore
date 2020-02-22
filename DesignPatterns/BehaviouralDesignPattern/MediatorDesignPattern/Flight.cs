//--------------------------------------------------------------------------------------------------------------------
// <copyright file="Flight.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.BehaviouralDesignPattern.MediatorDesignPattern
{
    using System;

    /// <summary>
    /// Flight class implements ICommand interface , used to send request for landing
    /// </summary>
    /// <seealso cref="DesignPatterns.BehaviouralDesignPattern.MediatorDesignPattern.ICommand" />
    public class Flight : ICommand
    {
        /// <summary>
        /// Air Traffic Control mediator
        /// </summary>
        private IATCMediator atcMediator;

        /// <summary>
        /// Initializes a new instance of the <see cref="Flight"/> class.
        /// </summary>
        /// <param name="atcMediator">Air Traffic Control mediator.</param>
        public Flight(IATCMediator atcMediator)
        {
            this.atcMediator = atcMediator;
        }

        /// <summary>
        /// Land method sends the status of landing 
        /// </summary>
        public void Land()
        {
            if (this.atcMediator.IsLandingOk())
            {
                Console.WriteLine("Successfully landed");
                this.atcMediator.SetLandingStatus(true);
            }
            else
            {
                Console.WriteLine("waiting for landing");
            }
        }

        /// <summary>
        /// Gets ready for landing
        /// </summary>
        public void GetReady()
        {
            Console.WriteLine("Ready for landing");
        }
    }
}