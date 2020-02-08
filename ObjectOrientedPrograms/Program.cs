using System;

namespace ObjectOrientedPrograms.InventoryManagement
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
                    InventoryDetails inventory = new InventoryDetails();
                    inventory.ReadingFromFile();
                    break;
                case 2:
                    Inventory3 inventorydata = new Inventory3();
                    inventorydata.calling();
                    break;
            }
        }
    }
}
