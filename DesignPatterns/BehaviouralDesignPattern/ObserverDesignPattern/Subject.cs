//--------------------------------------------------------------------------------------------------------------------
// <copyright file="Subject.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.BehaviouralDesignPattern.ObserverDesignPattern
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// MyTopic class implements Isubject interface
    /// </summary>
    /// <seealso cref="DesignPatterns.BehaviouralDesignPattern.ObserverDesignPattern.ISubject" />
    public class Subject : ISubject
    {
        /// <summary>
        /// The observer
        /// </summary>
        private List<IObserver> observers = new List<IObserver>();

        /// <summary>
        /// Gets or sets the name of the product.
        /// </summary>
        /// <value>
        /// The name of the product.
        /// </value>
        private string ProductName { get; set; }

        /// <summary>
        /// Gets or sets the product price.
        /// </summary>
        /// <value>
        /// The product price.
        /// </value>
        private int ProductPrice { get; set; }

        /// <summary>
        /// Gets or sets the availabitlity.
        /// </summary>
        /// <value>
        /// The availabitlity.
        /// </value>
        private string Availabitlity { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Subject"/> class.
        /// </summary>
        /// <param name="productName">Name of the product.</param>
        /// <param name="productPrice">The product price.</param>
        /// <param name="availability">The availability.</param>
        public Subject(string productName, int productPrice, string availability)
        {
            ProductName = productName;
            ProductPrice = productPrice;
            Availabitlity = availability;
        }

        /// <summary>
        /// Gets the availability.
        /// </summary>
        /// <returns></returns>
        public string GetAvailability()
        {
            return Availabitlity;
        }

        /// <summary>
        /// Sets the availability.
        /// </summary>
        /// <param name="availability">The availability.</param>
        public void SetAvailability(String availability)
        {
            this.Availabitlity = availability;
            Console.WriteLine("Availability changed from Out Of Stock to Available");
            NotifyObservers();
        }

        /// <summary>
        /// Registers the specified object.
        /// </summary>
        /// <param name="obj">The object.</param>
        public void Register(IObserver obj)
        {
            observers.Add(obj);
        }

        /// <summary>
        /// UnRegister the observers.
        /// </summary>
        /// <param name="obj">The object.</param>
        public void UnRegister(IObserver obj)
        {
            observers.Remove(obj);
        }

        /// <summary>
        /// Notifies the observers about changes.
        /// </summary>
        public void NotifyObservers()
        {
            Console.WriteLine("ProductName :" + ProductName + "product price :" + ProductPrice + " is Now " +
                "Available.So, Notify All Registered Users");
            foreach (IObserver observer in observers)
            {
                observer.Update(Availabitlity);
            }
        }
    }
}