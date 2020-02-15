using System;
using System.Collections.Generic;
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

        public Stocks NewStockAccount(string filename)
        {
            string jsonString = Utility.ReadFile(path);
            Console.WriteLine(jsonString);
            ////deserialize the object
            stocks = Utility.Deserializing(jsonString);
            return stocks;
        }

        public void PrintReport(Stocks stocks)
        {
            throw new NotImplementedException();
        }

        public void Save(string filename)
        {
            throw new NotImplementedException();
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
