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
    /// This class is used to call all other classes and their methods
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Singleton Design Pattern\n1.LazyIntializationSingleton\n" +
                "2.ThreadSafeSingleton\n3.EagerIntialization\n4.FactoryDesignPattern\n5.PrototypeDesignPattern" +
                "\n6.Adapter Design Pattern\n7.FacadeDesignPattern\n8.ProxyDesignPattern\n9.ObserverDesignPattern" +
                "\n10.VisitorDesignPattern\n11.MediatorDesignPattern");
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
                case 5:
                    PrototypeDesignPattern.PrototypeTest.Test();
                    break;
                case 6:
                    AdapterDesignPattern.AdapterDesignPatternTest.Test();
                    break;
                case 7:
                    FacadeDesignPattern.FacadeDesignPatternTest.Test();
                    break;
                case 8:
                    StructuralDesignPattern.ProxyDesignPattern.ProxyPatternTest.Test();
                    break;
                case 9:
                    BehaviouralDesignPattern.ObserverDesignPattern.ObserverPatternTest.Test();
                    break;
                case 10:
                    BehaviouralDesignPattern.VisitorDeisgnPattern.VisitorPatternTest.Test();
                    break;
                case 11:
                    BehaviouralDesignPattern.MediatorDesignPattern.MediatorDesignPatternTest.Test();
                    break;
                default:
                    Console.WriteLine("enter correct option");
                    break;

            }
        }
    }
}