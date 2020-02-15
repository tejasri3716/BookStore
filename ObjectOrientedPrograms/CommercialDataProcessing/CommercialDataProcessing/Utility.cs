using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ObjectOrientedPrograms.CommercialDataProcessing
{
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
        public static LinkedList CreateListNodeCompany()
        {
            LinkedList newNode = new LinkedList();
            return newNode;
        }
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
        public static bool DepositAvailable(int deposit, int numberOfShareToBuy, int sharePrice)
        {
            if (deposit >= (numberOfShareToBuy * sharePrice))
                return true;
            else
                return false;
        }
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
        public static void PrintTransaction(Stack1 stack)
        {
            Node2 temp;
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
        public static void PrintDateTime(Queue1 queue)
        {
            Node2 temp = null;
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
