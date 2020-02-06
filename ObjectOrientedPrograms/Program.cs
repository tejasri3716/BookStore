using System;

namespace ObjectOrientedPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.InventoryDetails");
            Console.WriteLine("enter an option to get executed");
            int option = Utility.readInt();
            switch(option)
            {
                case 1:
                    InventoryDetails.ReadingFromFile();
                    break;
            }
        }
    }
}
