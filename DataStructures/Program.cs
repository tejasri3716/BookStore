using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.UnOrderedListTest");
            Console.WriteLine("2.OrderedListTest");
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
            }
        }
    }
}
