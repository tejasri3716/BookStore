//--------------------------------------------------------------------------------------------------------------------
// <copyright file=Program.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace ObjectOrientedPrograms
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1.AddressBook\n2.Inventory\n3.InventoryDetails\n4.StockManagement\n9.DeckOfCards\n5.CommercialDataProcessing\n10.DeckOfCardsUsingQ");

            Console.WriteLine("enter an option to get executed");
            int option = Utility.readInt();
            switch (option)
            {
                case 1:
                    AddressBook.PersonDetails();
                    break;
                case 2:
                    Inventory.InventoryObject inventoryObject = new Inventory.InventoryObject();
                    inventoryObject.ReadingFromFile();
                    break;
                case 3:
                    InventoryManagement.InventoryDetails inventory = new InventoryManagement.InventoryDetails();
                    inventory.Operations();
                    break;
                case 4:
                    StockManagement.Stockdata();
                    break;
                case 5:
                    CommercialDataProcessing.StockOptions stockOptions = new CommercialDataProcessing.StockOptions();
                    stockOptions.StockOptionsMethod();
                    break;
                case 9:
                    DeckOfCards cards = new DeckOfCards();
                    cards.DistributeCards();
                    break;
                case 10:
                    DeckOfCardsUsingQueue.DeckOfCardsUsingQ.DistributeCards();
                    break;
            }
        }
    }
}