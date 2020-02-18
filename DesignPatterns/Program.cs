using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.LazyIntialization\n");
            Console.WriteLine("enter an option to get executed");
            int option = Utility.ReadInt();
            switch(option)
            {
                case 1:
                    SingletonDesignPattern.LazyIntializationTest.Test();
                    break;
            }
        }
    }
}
