//--------------------------------------------------------------------------------------------------------------------
// <copyright file="ObserverPatternTest.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.BehaviouralDesignPattern.ObserverDesignPattern
{
    using System;
    /// <summary>
    /// ObserverPatternTest class is used to test the Observer Design Pattern
    /// </summary>
    public class ObserverPatternTest
    {
        /// <summary>
        /// Test this instance.
        /// </summary>
        public static void Test()
        {
            Subject subject = new Subject("MI", 14000, "OutOfStock");
            Observer observer = new Observer("Radha", subject);
            Observer obs = new Observer("Indrani", subject);
            Observer ob = new Observer("Krishna", subject);
            Console.WriteLine("Mi Mobile is currently "+subject.GetAvailability());
            subject.SetAvailability("Available");
        }
    }
}