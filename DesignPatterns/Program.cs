using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Singleton Design Pattern\n 1.LazyIntializationSingleton\n2.ThreadSafeSingleton\n3.EagerIntialization\n4.FactoryDesignPattern");
            Console.WriteLine("enter an option to get executed");
            int option = Utility.ReadInt();
            switch(option)
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
