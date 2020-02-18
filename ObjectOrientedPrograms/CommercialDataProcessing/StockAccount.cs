//--------------------------------------------------------------------------------------------------------------------
// <copyright file="StockAccount.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace ObjectOrientedPrograms.CommercialDataProcessing
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// Stock Account class implements Stock Account Interface and overrides the methods in interface
    /// </summary>
    /// <seealso cref="ObjectOrientedPrograms.CommercialDataProcessing.StockAccountInterface" />
    class StockAccount : StockAccountInterface
    {
        Stocks stocks = null;
        CustomerShare CustomerShareAccount = null;
        /// <summary>
        /// Creates new stockaccount.
        /// </summary>
        /// <param name="filepath">The filepath.</param>
        /// <returns></returns>
        public  Stocks NewStockAccount(string filepath)
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
            IList<StockInfo> list = stocks.Stock;
            Console.WriteLine("ShareName \t  NumberOfShare \t SharePrice");
            foreach (var share in list)
                Console.WriteLine(share.StockName + "\t" + share.TotalShares + " \t" + share.SharePrice);
            PrintCustomerShareReport(CustomerShareAccount);
            Console.WriteLine("Remaining Deposit is : " + StockOptions.deposit);
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
            string jsonResultString = JsonConvert.SerializeObject(CustomerShareAccount);
            File.WriteAllText(fileName, jsonResultString);
        }
        /// <summary>
        /// Sells the specified stocks.
        /// </summary>
        /// <param name="stocks">The stocks.</param>
        /// <exception cref="NotImplementedException"></exception>
        public void Sell(Stocks stocks, Stack stack, Queue queue)
        {
            Console.WriteLine("enter the shareName to sell ");
            string shareName = Utility.readString();
            Console.WriteLine("enter the NumberOfShare to sell");
            int numberOfShare = Utility.readInt();

            ////check for available stock in companyshareobject inside Companylinkedlist and return companyshareobject
            CompanyShares companyShareObject = Utility.CheckShareAvailableInLinkedListCompany(CustomerShareAccount.Head, shareName, numberOfShare);
            if (companyShareObject == null)
            {
                Console.WriteLine("company share not available");
                return;
            }
            //// subtract share of stock from that companyshareobject that is inside companylinkedlist
            //// update into Memberstockobject
            Utility.MakeSell(numberOfShare, companyShareObject, stocks);
            string item = " sold \t" + companyShareObject.Symbol + "\t " + companyShareObject.TotalShares + "\t " + companyShareObject.DateTime;

            //// for every sell transaction , add the status to the queueCompanytransaction
            stack.Push(item);

            //// for every sell transaction add the status to the queueCompanytransaction
            queue.Enqueue(item);

            //// check if number of shares are equal then delete the node(companyShareObject).
            if (companyShareObject.TotalShares == 0)
                CustomerShareAccount.Head = Utility.DeleteListNodeCompany(CustomerShareAccount.Head, companyShareObject);
        }

        /// <summary>
        /// Creates new customershareaccount.
        /// </summary>
        /// <returns></returns>
        public CustomerShare NewCustomerShareAccount()
        {

            CustomerShareAccount = new CustomerShare();
            return CustomerShareAccount;
        }
        /// <summary>
        /// prints the value of total stock price
        /// </summary>
        /// <returns></returns>
        public double ValueOf()
        {
            double totalValue = 0.0;
            IList<StockInfo> list = stocks.Stock;
            foreach (var share in list)
                totalValue = share.TotalShares * share.SharePrice;
            return totalValue;
        }
        /// <summary>
        /// Buys the specified member stock portfolio object.
        /// </summary>
        /// <param name="stocks">The member stock portfolio object.</param>
        /// <param name="stack">The stack.</param>
        /// <param name="queue">The queue.</param>
        public void Buy(Stocks stocks, Stack stack, Queue queue)
        {
            CompanyShares companyShareObject = null;
            LinkedList newListNodeCompanyShare = null;
            Console.WriteLine("which share you want to buy : ");
            string shareName = Console.ReadLine();
            Console.WriteLine("how much number of share you want to buy : ");
            int numberOfShare = Convert.ToInt32(Console.ReadLine());

            ////check for availbale stock in memberStockObject
            ////look into the member stock object
            StockInfo memberStockShareAvailable = Utility.CheckShareAvailableInMemberStockObject(stocks, shareName, numberOfShare);
            if (memberStockShareAvailable == null)
            {
                Console.WriteLine("share not available");
                return;
            }
            ////check if deposit >= totalPrice of share. (numberOfshare * memberstockobjectlist.sharePrice)
            ////if false then return.

            ////fetch the CompanyObject reference from the linked list
            companyShareObject = Utility.CheckShareNameIsInLinkedListCompany(CustomerShareAccount.Head, shareName);

            ////create new companyobject wrap it in listnodecompany node and add to linked list
            if (companyShareObject == null)
            {
                companyShareObject = new CompanyShares();
                companyShareObject.Symbol = shareName;
                newListNodeCompanyShare = Utility.CreateListNodeCompany();
                //// update date time here
                newListNodeCompanyShare.Info = companyShareObject;
                //// add the newCompanyShare into linkedlist
                CustomerShareAccount.Head = Utility.AddListNodeCompany(CustomerShareAccount.Head, newListNodeCompanyShare);
            }

            //// decrease the numberoofshare from member stock object and add the number of share to CompanyObject of LinkedList
            Utility.MakePurchase(stocks, companyShareObject, numberOfShare);


            string item = " purchase \t" + companyShareObject.Symbol + "\t " + companyShareObject.TotalShares + "\t " + companyShareObject.DateTime;
            stack.Push(item);
            queue.Enqueue(item);
            //// for every Buy operation put the companyshareobject to the QueueCompanyTransaction
            ////add the companyshareObject to the stack.

        }

        /// <summary>
        /// Prints the customer share report.
        /// </summary>
        /// <param name="CustomerShareObject">The customer share object.</param>
        public void PrintCustomerShareReport(CustomerShare CustomerShareObject)
        {
            if (CustomerShareObject.Head == null)
                return;
            else
            {
                LinkedList temp = CustomerShareObject.Head;
                Console.WriteLine("shareName \t\t numberofshare");
                while (temp != null)
                {
                    Console.WriteLine(temp.Info.Symbol + "\t\t" + temp.Link + "\t");
                    temp = temp.Link;
                }
            }
        }
    }
}
