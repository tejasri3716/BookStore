using System;
namespace ObjectOrientedPrograms.InventoryManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1.InventoryDetails\n2.StockManagement\n3.DeckOfCards\n4.AddressBook\n5.CommercialDataProcessing");
           
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
                case 3:
                    DeckOfCards cards = new DeckOfCards();
                    cards.DistributeCards();
                    break;
                case 4:
                    AddressBook.PersonDetails();
                    break;
                case 5:
                    CommercialDataProcessing.StockOptions stockOptions = new CommercialDataProcessing.StockOptions();
                    stockOptions.StockOptionsMethod();
                    break;


            }
        }
    }
}
