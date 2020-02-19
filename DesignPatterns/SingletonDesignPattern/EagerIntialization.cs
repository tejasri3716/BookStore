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
    class EagerIntialization
    {
        private static int counter = 0;
        private EagerIntialization()
        {
            counter++;
            Console.WriteLine("counter value is :" + counter);
        }
        private static readonly EagerIntialization instance = new EagerIntialization();
        public static EagerIntialization GetInstance
        {
            get
            {
                return instance;
            }
        }
        public void PrintDetails(String message)
        {
            Console.WriteLine(message);
        }
    }
}
