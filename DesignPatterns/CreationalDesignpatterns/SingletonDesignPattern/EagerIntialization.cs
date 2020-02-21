//--------------------------------------------------------------------------------------------------------------------
// <copyright file="EagerIntialization.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.SingletonDesignPattern
{
    using System;
    /// <summary>
    /// EagerIntialization class used to check count of objects
    /// </summary>
    class EagerIntialization
    {
        private static int counter = 0;
        /// <summary>
        /// Prevents a default instance of the <see cref="EagerIntialization"/> class from being created.
        /// </summary>
        private EagerIntialization()
        {
            counter++;
            Console.WriteLine("counter value is :" + counter);
        }
        /// <summary>
        /// The instance
        /// </summary>
        private static readonly EagerIntialization instance = new EagerIntialization();
        /// <summary>
        /// Gets the get instance.
        /// </summary>
        /// <value>
        /// The get instance.
        /// </value>
        public static EagerIntialization GetInstance
        {
            get
            {
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
