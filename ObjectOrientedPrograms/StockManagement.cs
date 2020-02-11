using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms
{
    class StockManagement
    {
        public static void Stockdata()
        {
            String stockfile = @"C:\Users\BridgeLabz\source\repos\ObjectOrientedPrograms\TotalStock.json";
            String stockreading = Utility.ReadFile(stockfile);
            Console.WriteLine(stockreading);
            StockPortfolio stockObject = Utility.Deserialization(stockfile);
            Utility.DisplayStock(stockObject);
        }
    }
}
