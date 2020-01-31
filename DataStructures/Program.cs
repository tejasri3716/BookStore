using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.UnOrderedListTest");
            Console.WriteLine("2.OrderedListTest");
            Console.WriteLine("3.BalancedParanthesis");
            int option = Utility.readInt();
            switch(option)
            {
                case 1:
                 UnOrderedListTest.ReadInputFromFile();
                    break;
                case 2:
                     OrderedListTest.Test();
                   // OrderedListTest.ReadingNumbersFromFile();
                    break;
                case 3:
                    BalancedParanthesis.balancedParanthesis();
                    break;
            }
        }
    }
}
