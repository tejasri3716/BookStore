//--------------------------------------------------------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
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
    /// Utility Class used to read all data types and consists of logic of Commercial Data Processing Problem
    /// </summary>
    class Utility
    {
        /// <summary>
        /// Reads the integer value.
        /// </summary>
        /// <returns></returns>
        public static int readInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        /// <summary>
        /// Reads the string.
        /// </summary>
        /// <returns></returns>
        public static string readString()
        {
            return Console.ReadLine();
        }
        /// <summary>
        /// Reads the double value.
        /// </summary>
        /// <returns></returns>
        public static double readDouble()
        {
            return Convert.ToDouble(Console.ReadLine());
        }
        /// <summary>
        /// Reads the file.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns></returns>
        public static string ReadFile(string path)
        {
            string jsonfile = "";
            try
            {
                jsonfile = File.ReadAllText(path);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return jsonfile;
        }
        /// <summary>
        /// Deserializings the specified jsonfile.
        /// </summary>
        /// <param name="Jsonfile">The jsonfile.</param>
        /// <returns></returns>
        public static Stocks Deserializing(string Jsonfile)
        {
            Stocks stocks = null;
            try
            {
                stocks = JsonConvert.DeserializeObject<Stocks>(Jsonfile);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return stocks;
        }
        /// <summary>
        /// Creates the list node company.
        /// </summary>
        /// <returns></returns>
        public static LinkedList CreateListNodeCompany()
        {
            LinkedList newNode = new LinkedList();
            return newNode;
        }
        /// <summary>
        /// Checks the share available in member stock object.
        /// </summary>
        /// <param name="stocks">The stocks.</param>
        /// <param name="shareName">Name of the share.</param>
        /// <param name="totalShares">The total shares.</param>
        /// <returns></returns>
        public static StockInfo CheckShareAvailableInMemberStockObject(Stocks stocks, string shareName, int totalShares)
        {
            IList<StockInfo> list = stocks.Stock;
            foreach (var share in list)
                if ((share.StockName).Equals(shareName))
                    if (share.TotalShares >= totalShares && StockOptions.deposit >= (share.TotalShares * share.SharePrice))
                        return share;
                    else
                        Console.WriteLine("number of share is only : {0} ", share.TotalShares);
            return null;
        }
        /// <summary>
        /// Checks the share available in linked list company.
        /// </summary>
        /// <param name="head">The head.</param>
        /// <param name="shareName">Name of the share.</param>
        /// <param name="numberOfShare">The number of share.</param>
        /// <returns></returns>
        public static CompanyShares CheckShareAvailableInLinkedListCompany(LinkedList head, string shareName, int numberOfShare)
        {
            LinkedList temp = null;
            if (head == null)
                return null;
            else if ((head.Info.Symbol).Equals(shareName) && (head.Info.TotalShares >= numberOfShare))
                return head.Info;
            else
            {
                temp = head;
                while (temp != null)
                {
                    if ((temp.Info.Symbol).Equals(shareName) && temp.Info.TotalShares >= numberOfShare)
                        return temp.Info;
                    temp = temp.Link;
                }
            }
            return null;
        }
        /// <summary>
        /// Checks the share name is in linked list company.
        /// </summary>
        /// <param name="head">The head.</param>
        /// <param name="shareName">Name of the share.</param>
        /// <returns></returns>
        public static CompanyShares CheckShareNameIsInLinkedListCompany(LinkedList head, string shareName)
        {
            LinkedList temp = null;
            if (head == null)
                return null;
            else if ((head.Info.Symbol).Equals(shareName))
                return head.Info;
            else
            {
                temp = head;
                while (temp != null)
                {
                    if ((temp.Info.Symbol).Equals(shareName))
                        return temp.Info;
                    temp = temp.Link;
                }
            }
            return null;
        }
        /// <summary>
        ///checks if Deposits is available or not.
        /// </summary>
        /// <param name="deposit">The deposit.</param>
        /// <param name="numberOfShareToBuy">The number of share to buy.</param>
        /// <param name="sharePrice">The share price.</param>
        /// <returns></returns>
        public static bool DepositAvailable(int deposit, int numberOfShareToBuy, int sharePrice)
        {
            if (deposit >= (numberOfShareToBuy * sharePrice))
                return true;
            else
                return false;
        }
        /// <summary>
        /// Makes the purchase.
        /// </summary>
        /// <param name="stocks">The stocks.</param>
        /// <param name="CompanyShareObject">The company share object.</param>
        /// <param name="numberOfShare">The number of share.</param>
        public static void MakePurchase(Stocks stocks, CompanyShares CompanyShareObject, int numberOfShare)
        {
            IList<StockInfo> list = stocks.Stock;
            foreach (var share in list)
                if (share.StockName.Equals(CompanyShareObject.Symbol))
                {
                    share.TotalShares = share.TotalShares - numberOfShare;
                    CompanyShareObject.TotalShares = CompanyShareObject.TotalShares + numberOfShare;
                    StockOptions.deposit -= (CompanyShareObject.TotalShares * share.SharePrice);
                    CompanyShareObject.DateTime = DateTime.Now;
                }
        }
        /// <summary>
        /// Makes the sell.
        /// </summary>
        /// <param name="numberOfShare">The number of share.</param>
        /// <param name="CompanyShareObject">The company share object.</param>
        /// <param name="stocks">The stocks.</param>
        public static void MakeSell(int numberOfShare, CompanyShares CompanyShareObject, Stocks stocks)
        {
            IList<StockInfo> list = stocks.Stock;
            foreach (var share in list)
                if (share.StockName.Equals(CompanyShareObject.Symbol))
                {
                    share.TotalShares += numberOfShare;
                    CompanyShareObject.TotalShares -= numberOfShare;
                    StockOptions.deposit += share.TotalShares * share.SharePrice;
                    CompanyShareObject.DateTime = DateTime.Now;
                }
        }
        /// <summary>
        /// Adds the list node company.
        /// </summary>
        /// <param name="head">The head.</param>
        /// <param name="newListNodeCompanyShare">The new list node company share.</param>
        /// <returns></returns>
        public static LinkedList AddListNodeCompany(LinkedList head, LinkedList newListNodeCompanyShare)
        {
            if (head == null)
                head = newListNodeCompanyShare;
            else
            {
                LinkedList temp = head;
                while (temp.Link != null)
                    temp = temp.Link;
                temp.Link = newListNodeCompanyShare;
            }
            return head;
        }
        /// <summary>
        /// Deletes the list node company.
        /// </summary>
        /// <param name="head">The head.</param>
        /// <param name="CompanyShareObject">The company share object.</param>
        /// <returns></returns>
        public static LinkedList DeleteListNodeCompany(LinkedList head, CompanyShares CompanyShareObject)
        {
            LinkedList temp = null;
            if (head == null)
                return null;
            else if ((head.Info.Symbol).Equals(CompanyShareObject.Symbol))
                head = head.Link;
            else
            {
                temp = head;
                while (temp.Link != null && !((temp.Link.Info.Symbol).Equals(CompanyShareObject.Symbol)))
                    temp = temp.Link;
                if (temp.Link != null)
                    if ((temp.Link.Info.Symbol).Equals(CompanyShareObject.Symbol))
                        temp.Link = temp.Link.Link;
                    else
                        Console.WriteLine("listnodecompany node not found");
            }
            return head;
        }
        /// <summary>
        /// Prints the transaction.
        /// </summary>
        /// <param name="stack">The stack.</param>
        public static void PrintTransaction(Stack stack)
        {
            Node temp;
            if (stack == null || stack.top == null)
                return;
            else
            {
                temp = stack.top;
                while (temp != null)
                {
                    Console.WriteLine(temp.Data);
                    temp = temp.Link;
                }

            }
        }
        /// <summary>
        /// Prints date and time.
        /// </summary>
        /// <param name="queue">The queue.</param>
        public static void PrintDateTime(Queue queue)
        {
            Node temp = null;
            if (queue == null)
                return;
            else
            {
                temp = queue.front;
                while (temp != null)
                {
                    Console.WriteLine(temp.Data);
                    temp = temp.Link;
                }
            }
        }
    }
}
