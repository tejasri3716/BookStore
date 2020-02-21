//--------------------------------------------------------------------------------------------------------------------
// <copyright file="AdapterDesignPatternTest.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.AdapterDesignPattern
{
    using System;

    /// <summary>
    /// AdapterDesignPatternTest class is used to test adapter pattern
    /// </summary>
    public class AdapterDesignPatternTest
    {
        /// <summary>
        /// Test the interface and class are working together or not
        /// </summary>
        public static void Test()
        {
            //// Instantiate SocketAdaptorImpl class object 
            SocketAdapterImplementation socketImplObject = new SocketAdapterImplementation();
            //// call various methods using the socketImplobject
            Volt volt3 = socketImplObject.Get3Volts();
            Volt volt12 = socketImplObject.Get12Volts();
            Volt volt120 = socketImplObject.Get120Volts();
            //// print all the values
            Console.WriteLine(" volts : " + volt3.GetVolts());
            Console.WriteLine(" volts : " + volt12.GetVolts());
            Console.WriteLine(" volts : " + volt120.GetVolts());
        }
    }
}
