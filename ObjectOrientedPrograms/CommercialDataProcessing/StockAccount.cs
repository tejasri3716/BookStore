using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ObjectOrientedPrograms.CommercialDataProcessing
{
    class StockAccount : StockAccountInterface
    {
        Stocks stocks= null;
        CustomerShare NewCustomerShareAccount = null;

        public void Buy(Stocks stocks)
        {
            throw new NotImplementedException();
        }

        public Stocks NewStockAccount(string filepath)
        {
            string jsonString = Utility.ReadFile(filepath);
            Console.WriteLine(jsonString);
            ////deserialize the object
            stocks = Utility.Deserializing(jsonString);
            return stocks;
        }
        /// <summary>
        /// Prints the report.
        /// </summary>
        /// <param name="stocks">The stocks.</param>
        /// <exception cref="NotImplementedException"></exception>
        public void PrintReport(Stocks stocks)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Saves the specified file name.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        public void Save(string fileName)
        {
            string jsonResultString = JsonConvert.SerializeObject(stocks);
            File.WriteAllText(fileName, jsonResultString);
        }

        /// <summary>
        /// Saves the customer share to a file (serialize)
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        public void SaveCustomerShare(string fileName)
        {
            string jsonResultString = JsonConvert.SerializeObject(NewCustomerShareAccount);
            File.WriteAllText(fileName, jsonResultString);
        }
        public void Sell(Stocks stocks)
        {
            throw new NotImplementedException();
        }

        public double ValueOf()
        {
            throw new NotImplementedException();
        }
    }
}
