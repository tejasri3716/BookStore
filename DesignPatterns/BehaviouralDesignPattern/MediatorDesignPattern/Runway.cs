//--------------------------------------------------------------------------------------------------------------------
// <copyright file="Runway.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.BehaviouralDesignPattern.MediatorDesignPattern
{
    using System;

    /// <summary>
    /// Runway class implements ICommand interface which is used to give permission to land
    /// </summary>
    /// <seealso cref="DesignPatterns.BehaviouralDesignPattern.MediatorDesignPattern.ICommand" />
    public class Runway : ICommand
    {
        /// <summary>
        /// Air Traffic Control mediator
        /// </summary>
        private IATCMediator atcMediator;

        /// <summary>
        /// Initializes a new instance of the <see cref="Runway"/> class.
        /// </summary>
        /// <param name="atcMediator">Air Traffic Control mediator.</param>
        public Runway(IATCMediator atcMediator)
        {
            this.atcMediator = atcMediator;
            this.atcMediator.SetLandingStatus(true);
        }

        /// <summary>
        /// Lands this instance.
        /// </summary>
        public void Land()
        {
            Console.WriteLine("Landing permission granted");
            this.atcMediator.SetLandingStatus(true);
        }
    }
}