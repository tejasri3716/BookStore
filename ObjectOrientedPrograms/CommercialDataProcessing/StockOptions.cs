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
        public static StockAccount stockAccountObject = null;
        /// <summary>
        /// Stocks the options method.
        /// </summary>
         Stack1 stack = new Stack1();

        /// <summary>
        /// The queue Using linked list
        /// </summary>
        Queue1 queue = new Queue1();

        public void StockOptionsMethod()
        {

            String StockFilePath = @"C:\Users\BridgeLabz\source\repos\ObjectOrientedPrograms\CommercialDataProcessing\StockList.json";
            String CustomerFilePath = @"C:\Users\BridgeLabz\source\repos\ObjectOrientedPrograms\CommercialDataProcessing\Customer.json";
            stockAccountObject = new StockAccount();
            int option = Utility.readInt();
            do
            {
                Console.WriteLine("enter any option to get executed");
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

                switch (option)
                {
                    case 1:
                        stocks = stockAccountObject.NewStockAccount(StockFilePath);
                        NewCustomerShareAccount = stockAccountObject.CustomerShareAccountMethods();
                        break;
                    case 2:
                        Console.WriteLine("total value of all the stock shares are : {0}", stockAccountObject.ValueOf());
                        break;

                    case 3:
                        stockAccountObject.Buy(stocks, stackLL, queueLL);
                        stockAccountObject.PrintReport(stocks);
                        break;

                    case 4:
                        stockAccountObject.Sell(stocks, stackLL, queueLL);
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

                    default:
                        Console.WriteLine("enter correct option");
                        break;
                }

            } while (option < 11);
        }
    }
}
