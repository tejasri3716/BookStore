//--------------------------------------------------------------------------------------------------------------------
// <copyright file="EagerIntializationTest.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.SingletonDesignPattern
{
    using System.Threading.Tasks;
    /// <summary>
    /// EagerIntializationTest to test the EagerIntialization in Singleton Design Pattern
    /// </summary>
    class EagerIntializationTest
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
        /// Seconds the instance.
        /// </summary>
        private static void SecondInstance()
        {
            // Another Object created for thread safes intialization class
            ThreadSafeSingleton threadSafeIntialization = ThreadSafeSingleton.GetInstance;
            threadSafeIntialization.PrintDetails("this is my second instance of object");
        }
        /// <summary>
        /// Firsts the instance.
        /// </summary>
        private static void FirstInstance()
        {
            // Object creation for thread safe intialization singleton class
            ThreadSafeSingleton intialization = ThreadSafeSingleton.GetInstance;
            intialization.PrintDetails("this is my first instance of object");
        }
    }
}
