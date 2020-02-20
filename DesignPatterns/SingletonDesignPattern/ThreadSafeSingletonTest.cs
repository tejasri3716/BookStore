//--------------------------------------------------------------------------------------------------------------------
// <copyright file="ThreadSafeSingletonTest.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.SingletonDesignPattern
{
    using System.Threading.Tasks;
    /// <summary>
    /// ThreadSafeSingletonTest class is used invoke methods simulataneously to check thread safety
    /// </summary>
    class ThreadSafeSingletonTest
    {
        /// <summary>
        /// Tests this instance.
        /// </summary>
        public static void Test()
        {
            Parallel.Invoke(
                () => FirstInstance(),
                () => SecondInstance()
                );
        }
        /// <summary>
        /// Second instance method 
        /// </summary>
        private static void SecondInstance()
        {
            // Another Object created for thread safe intialization class
            ThreadSafeSingleton threadSafeIntialization = ThreadSafeSingleton.GetInstance;
            threadSafeIntialization.PrintDetails("this is my second instance of object");
        }
        /// <summary>
        /// First instance method
        /// </summary>
        private static void FirstInstance()
        {
            // Object creation for thread safe intialization singleton class
            ThreadSafeSingleton intialization = ThreadSafeSingleton.GetInstance;
            intialization.PrintDetails("this is my first instance of object");
        }
    }
}
