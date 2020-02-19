//--------------------------------------------------------------------------------------------------------------------
// <copyright file="PrototypeTest.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SingletonDesignPattern
{
    public sealed class LazyIntialization
    {
        private static LazyIntialization instance = null;
        private static int counter = 0;
        private LazyIntialization()
        {
            counter++;
            Console.WriteLine("counter value is :" + counter);
        }
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
        public void PrintDetails(String message)
        {
            Console.WriteLine(message);
        }
    }
}
