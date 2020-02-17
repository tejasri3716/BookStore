using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms.CommercialDataProcessing
{
    /// <summary>
    /// Class to select any of the Options Listed Below
    /// </summary>
    class StockOptions
    {
        /// <summary>
        /// The deposit
        /// </summary>
        public static double deposit = 50000000;
        /// <summary>
        /// The stocks class Object
        /// </summary>
        Stocks stocks = null;
        /// <summary>
        /// Creates new customershareaccount.
        /// </summary>
        CustomerShare NewCustomerShareAccount = null;
        /// <summary>
        /// The stock account object
        /// </summary>
        public  StockAccount stockAccountObject = null;
        /// <summary>
        /// Stocks the options method.
        /// </summary>
        Stack stack = new Stack();

        /// <summary>
        /// The queue Using linked list
        /// </summary>
        Queue queue = new Queue();

        public void StockOptionsMethod()
        {
            int option = 0;
            String StockFilePath = @"C:\Users\BridgeLabz\source\repos\ObjectOrientedPrograms\CommercialDataProcessing\StockList.json";
            String CustomerFilePath = @"C:\Users\BridgeLabz\source\repos\ObjectOrientedPrograms\CommercialDataProcessing\Customer.json";
            stockAccountObject = new StockAccount();
            if (stockAccountObject == null)
                Console.WriteLine("object is null");
            while (option != 99)
            {
                Console.WriteLine(" 1. Create New StockAccount and CustomerShareAccount");
                Console.WriteLine(" 2. Total Value of stockAccount");
                Console.WriteLine(" 3. Buy share ");
                Console.WriteLine(" 4. Sell Share");
                Console.WriteLine(" 5. save stock data back to file");
                Console.WriteLine(" 6. save customer share to file");
                Console.WriteLine(" 7. PrintReport of stock");
                Console.WriteLine(" 8. printReport of customer stock");
                Console.WriteLine(" 9. print transaction done using stack");
                Console.WriteLine("10. print Date time of transaction using Queue");
                Console.WriteLine("enter any option to get executed");
                option = Utility.readInt();
                switch (option)
                {
                    case 1:
                        stocks = stockAccountObject.NewStockAccount(StockFilePath);
                        NewCustomerShareAccount = stockAccountObject.NewCustomerShareAccount();
                        break;
                    case 2:
                        Console.WriteLine("total value of all the stock shares are : {0}", stockAccountObject.ValueOf());
                        break;

                    case 3:
                        stockAccountObject.Buy(stocks, stack, queue);
                        stockAccountObject.PrintReport(stocks);
                        break;

                    case 4:
                        stockAccountObject.Sell(stocks, stack, queue);
                        stockAccountObject.PrintReport(stocks);
                        break;

                    case 5:
                        stockAccountObject.Save(StockFilePath);
                        break;

                    case 6:
                        stockAccountObject.SaveCustomerShare(CustomerFilePath);
                        break;

                    case 7:
                        stockAccountObject.PrintReport(stocks);
                        break;

                    case 8:
                        stockAccountObject.PrintCustomerShareReport(NewCustomerShareAccount);
                        break;

                    case 9:
                        Utility.PrintTransaction(stack);
                        break;

                    case 10:
                        Utility.PrintDateTime(queue);
                        break;
                    case 99:
                        return;
                    default:
                        Console.WriteLine("enter correct option");
                        break;
                }

            }

        }
    }
}
