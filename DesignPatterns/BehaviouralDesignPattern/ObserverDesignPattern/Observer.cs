//--------------------------------------------------------------------------------------------------------------------
// <copyright file="Observer.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.BehaviouralDesignPattern.ObserverDesignPattern
{
    using System;

    /// <summary>
    /// MyTopicSubscriber class implements IObserver interface
    /// </summary>
    /// <seealso cref="DesignPatterns.BehaviouralDesignPattern.ObserverDesignPattern.IObserver" />
    public class Observer : IObserver
    {
        /// <summary>
        /// The name
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Observer"/> class.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <param name="subject">The subject.</param>
        public Observer(string userName,ISubject subject)
        {
            this.UserName = userName;
            subject.Register(this);
        }

        /// <summary>
        /// Updates the observer, used by subject
        /// </summary>
        /// <param name="availability"></param>
        public void Update(string availability)
        {
           Console.WriteLine(" Hello "+UserName +" Product is Now "+availability +" on Amazon");
         
        }

       
    }
}