//--------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns
{
    using System;

    /// <summary>
    /// This class is used to call all other class and their methods
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Singleton Design Pattern\n 1.LazyIntializationSingleton\n2.ThreadSafeSingleton\n3.EagerIntialization\n4.FactoryDesignPattern");
            Console.WriteLine("enter an option to get executed");
            int option = Utility.ReadInt();
            switch (option)
            {
                case 1:
                    SingletonDesignPattern.LazyIntializationTest.Test();
                    break;
                case 2:
                    SingletonDesignPattern.ThreadSafeSingletonTest.Test();
                    break;
                case 3:
                    SingletonDesignPattern.EagerIntializationTest.Test();
                    break;
                case 4:
                    FactoryDesignPattern.FactoryTest.Test();
                    break;
            }
        }
    }
}
