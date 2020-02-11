using System;
namespace ObjectOrientedPrograms.InventoryManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1.InventoryDetails\n2.StockManagement");
           
            Console.WriteLine("enter an option to get executed");
            int option = Utility.readInt();
            switch(option)
            {
                case 1:
                    InventoryDetails inventory = new InventoryDetails();
                    inventory.ReadingFromFile();
                    break;
                case 2:
                    StockManagement.Stockdata();
                    break;

               
            }
        }
    }
}
