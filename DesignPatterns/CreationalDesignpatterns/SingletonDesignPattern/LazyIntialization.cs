//--------------------------------------------------------------------------------------------------------------------
// <copyright file="LazyIntialization.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.SingletonDesignPattern
{
    using System;
    /// <summary>
    /// Sealed Class Lazy Intialization used check the no of objects intialized
    /// </summary>
    public sealed class LazyIntialization
    {
        private static LazyIntialization instance = null;
        private static int counter = 0;
        /// <summary>
        /// Prevents a default instance of the <see cref="LazyIntialization"/> class from being created.
        /// </summary>
        private LazyIntialization()
        {
            counter++;
            Console.WriteLine("counter value is :" + counter);
        }
        /// <summary>
        /// Gets the object if it is null
        /// </summary>
        /// <value>
        /// The get instance.
        /// </value>
        public static LazyIntialization GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new LazyIntialization();
               // Console.WriteLine("first");

                return instance;
            }
        }
        /// <summary>
        /// Prints the details.
        /// </summary>
        /// <param name="message">The message.</param>
        public void PrintDetails(String message)
        {
            Console.WriteLine(message);
        }
    }
}
