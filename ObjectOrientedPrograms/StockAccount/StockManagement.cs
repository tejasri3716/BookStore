//--------------------------------------------------------------------------------------------------------------------
// <copyright file=StockManagement.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace ObjectOrientedPrograms
{
    using System;

    /// <summary>
    /// Stock Management class used to read file and deserialize it
    /// </summary>
    class StockManagement
    {
        public static void Stockdata()
        {
            String stockfile = @"C:\Users\BridgeLabz\source\repos\ObjectOrientedPrograms\StockAccount\TotalStock.json";
            String stockreading = Utility.ReadFile(stockfile);
            Console.WriteLine(stockreading);
            StockPortfolio stockObject = Utility.Deserialization(stockreading);
            if (stockObject == null)
            {
                Console.WriteLine("object is null");
            }
            Utility.DisplayStock(stockObject);
        }
    }
}
