using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AdapterDesignPattern
{
    public class AdapterDesignPatternTest
    {
        /// <summary>
        /// executes the Adaptordesignpatterntestmethod.
        /// </summary>
        public static void Test()
        {
            //// Instantiate SocketAdaptorImpl class object 
            SocketAdapterImplementation socketImplObject = new SocketAdapterImplementation();
            ////call various methods using the socketImplobject
            Volt volt3 = socketImplObject.Get3Volts();
            Volt volt12 = socketImplObject.Get12Volts();
            Volt volt120 = socketImplObject.Get120Volts();
            ////print all the values
            Console.WriteLine(" volts : " + volt3.GetVolts());
            Console.WriteLine(" volts : " + volt12.GetVolts());
            Console.WriteLine(" volts : " + volt120.GetVolts());
        }
    }
}
