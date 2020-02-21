//--------------------------------------------------------------------------------------------------------------------
// <copyright file="ThreadSafeSingleton.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.SingletonDesignPattern
{
    using System;
    /// <summary>
    /// ThreadSafeSingleton class is used to intialize object 
    /// </summary>
    class ThreadSafeSingleton
    {
        private static ThreadSafeSingleton instance = null;
        private static int counter = 0;
        private static readonly object obj = new object();
        /// <summary>
        /// Prevents a default instance of the <see cref="ThreadSafeSingleton"/> class from being created.
        /// </summary>
        private ThreadSafeSingleton()
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
        public static ThreadSafeSingleton GetInstance
        {
            get
            {
                if (instance == null)
                {                           // double checked locking
                    lock (obj)
                    {                           // using lock only one thread can enter into this block at a given point of time
                        if (instance == null)
                            instance = new ThreadSafeSingleton();
                    }
                }
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
