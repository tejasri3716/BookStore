//--------------------------------------------------------------------------------------------------------------------
// <copyright file="LazyIntializationTest.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.SingletonDesignPattern
{
    /// <summary>
    /// Class for Testing Lazy Intialization
    /// </summary>
  public  class LazyIntializationTest
    {
        /// <summary>
        /// Test Method is used to check how many instances are created for Lazy Intialization class
        /// </summary>
        public static void Test()
        {
            // Object creation for lazy intialization singleton class
            LazyIntialization lazyIntialization = LazyIntialization.GetInstance;
            lazyIntialization.PrintDetails("this is my first instance of object");
            // Another Object created for lazy intialization class
            LazyIntialization intialization = LazyIntialization.GetInstance;
            intialization.PrintDetails("this is my second instance of object");
        }
    }
}
