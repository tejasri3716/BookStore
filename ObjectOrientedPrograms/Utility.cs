using Newtonsoft.Json;
using ObjectOrientedPrograms.InventoryManagement;
using System;
using System.Collections.Generic;
using System.IO;

namespace ObjectOrientedPrograms
{
    class Utility
    {
        public static int readInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        public static string readString()
        {
            return Console.ReadLine();
        }
        public static double readDouble()
        {
            return Convert.ToDouble(Console.ReadLine());
        }
        /* public static string Writefile(string path, Object r)
         {
             var s = JsonConvert.SerializeObject(r, Formatting.Indented);
             *//*var writter = new StreamWriter(path);
             writter.Write(jsonwrite);*//*
             String json = path;
             File.WriteAllText(json, s);
             Console.WriteLine(s);
             return "";
         }*/
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
        public static Model Deserializing(string Jsonfile)
        {
            Model file = null;
            try
            {
                file = JsonConvert.DeserializeObject<Model>(Jsonfile);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return file;
        }
        /// <summary>
        /// Serializings the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="jsonfile">The jsonfile.</param>
        public static void Serializing(Model model, string jsonfile)
        {
            try
            {
                string jsonResultString = JsonConvert.SerializeObject(model);
                File.WriteAllText(jsonfile, jsonResultString);
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
        }
        /// <summary>
        /// Adds the rice.
        /// </summary>
        /// <param name="model">The model.</param>
        public static void AddRice(Model model)
        {
            List<InventoryData> rice = model.Rices;
            InventoryData newitem = new InventoryData();
            Console.WriteLine("enter the rice variety");
            newitem.Name = Utility.readString();
            Console.WriteLine("enter the price");
            newitem.Price = Utility.readDouble();
            Console.WriteLine("enter weight");
            newitem.Weight = Utility.readDouble();
            rice.Add(newitem);
            model.Rices = rice;
        }
        public static void AddWheats(Model model)
        {
            List<InventoryData> wheat = model.Wheats;
            InventoryData wheats = new InventoryData();
            Console.WriteLine("enter the wheat variety name");
            wheats.Name = Utility.readString();
            Console.WriteLine("enter the price");
            wheats.Price = Utility.readDouble();
            Console.WriteLine("enter weight");
            wheats.Weight = Utility.readDouble();
            wheat.Add(wheats);
            model.Wheats = wheat;
        }
        /// <summary>
        /// Adds the pulses.
        /// </summary>
        /// <param name="model">The model.</param>
        public static void AddPulses(Model model)
        {
            List<InventoryData> pulses = model.Pulses;
            InventoryData newpulses = new InventoryData();
            Console.WriteLine("enter the pulses variety name");
            newpulses.Name = Utility.readString();
            Console.WriteLine("enter the price");
            newpulses.Price = Utility.readDouble();
            Console.WriteLine("enter weight");
            newpulses.Weight = Utility.readDouble();
            pulses.Add(newpulses);
            model.Pulses = pulses;
        }
        /// <summary>
        /// Removes the item rice.
        /// </summary>
        /// <param name="model">The model.</param>
        public static void RemoveItemRice(Model model)
        {
            List<InventoryData> rices = model.Rices;
            Console.WriteLine("enter variety of rice to get removed from the list");
            string removeitem = Utility.readString();
            foreach (var rice in rices)
            {
                if ((rice.Name).Equals(removeitem))
                {
                    rices.Remove(rice);
                    break;
                }
            }

        }
        /// <summary>
        /// Removes the item wheat.
        /// </summary>
        /// <param name="model">The model.</param>
        public static void RemoveItemWheat(Model model)
        {
            List<InventoryData> wheats = model.Wheats;
            Console.WriteLine("enter an item to get removed from the list");
            String removeitem = Utility.readString();
            foreach (var wheat in wheats)
            {
                if (wheat.Name == removeitem)
                {
                    wheats.Remove(wheat);
                    break;
                }
            }
        }
        /// <summary>
        /// Removes the item pulses.
        /// </summary>
        /// <param name="model">The model.</param>
        public static void RemoveItemPulses(Model model)
        {
            List<InventoryData> pulses = model.Pulses;
            Console.WriteLine("enter an item to get removed from the list");
            String removeitem = Utility.readString();
            foreach (var pulse in pulses)
            {
                if (pulse.Name == removeitem)
                {
                    pulses.Remove(pulse);
                    break;
                }
            }
        }
        /// <summary>
        /// Removes the item.
        /// </summary>
        /// <param name="model">The model.</param>
        public static void RemoveItem(Model model)
        {
            List<InventoryData>[] inventory = new List<InventoryData>[3];
            inventory[0] = model.Rices;
            inventory[1] = model.Wheats;
            inventory[2] = model.Pulses;
            Console.WriteLine("enter an item to get removed from the list");
            String removeitem = Utility.readString();
            foreach (var items in inventory)   //for rices or wheats or pulses
            {
                foreach (var item in items) //for variety of each inventory
                {
                    if (item.Name == removeitem)
                    {
                        items.Remove(item);
                    }
                }
            }
        }
        /// <summary>
        /// Updates the data.
        /// </summary>
        /// <param name="model">The model.</param>
        public static void UpdateData(Model model)
        {
            List<InventoryData>[] inventory = new List<InventoryData>[3];
            inventory[0] = model.Rices;
            inventory[1] = model.Wheats;
            inventory[2] = model.Pulses;
            Console.WriteLine("enter LastName of a person to update in the list");
            String updateitem = Utility.readString();
            foreach (var items in inventory)   //for rices or wheats or pulses
            {
                foreach (var item in items) //for variety of each inventory
                {
                    if (item.Name == updateitem)
                    {
                        Console.WriteLine("enter any property to get updated");
                        String property = Utility.readString();
                        if (property == "Name")
                        {
                            Console.WriteLine("enter a new name to get updated");
                            String newName = Utility.readString();
                            item.Name = newName;
                        }
                        if (property == "Weight")
                        {
                            Console.WriteLine("enter a new weight to get updated");
                            Double newWeight = Utility.readDouble();
                            item.Weight = newWeight;
                        }
                        if (property == "Price")
                        {
                            Console.WriteLine("enter a new price to get updated");
                            Double newPrice = Utility.readDouble();
                            item.Price = newPrice;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Displays the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        public static void Display(Model model)
        {
            List<InventoryData>[] list = new List<InventoryData>[3];
            list[0] = model.Rices;
            list[1] = model.Wheats;
            list[2] = model.Pulses;
            Console.WriteLine("\n");
            Console.WriteLine("Name\t\t\tPrice\t\t\tWeight\t\t\tTotalPrice");
            foreach (var items in list)
            {
                foreach (var item in items)
                {
                    Console.WriteLine(item.Name + "\t\t\t" + item.Price + "\t\t\t" + item.Weight + "\t\t\t" + (item.Price * item.Weight));
                }
            }
        }
        ///For Stock Management
        ///Deserialization
        ///Serialization
        public static StockPortfolio Deserialization(String stockfile)
        {
            StockPortfolio stockobj = null;
            try
            {
                stockobj = JsonConvert.DeserializeObject<StockPortfolio>(stockfile);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }
            return stockobj;
        }
        public static void DisplayStock(StockPortfolio stockObj)
        {
            try
            {
                IList<StockInfo> list = stockObj.TotalStocks;
                Console.WriteLine("StockName\t\t\tPrice\t\tShare\t\tTotalPrice");
                if (stockObj != null)
                {
                    foreach (var stock in list)
                    {
                        Console.WriteLine(stock.StockName + "\t\t\t" + stock.Price + "\t\t" + stock.Share + "\t\t" + ((stock.Share) * (stock.Price)));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }
        }
        ///for Deck of Cards 
        ///for shuffling cards
        ///for converting to 2d array
        public static int RandomValues(int num)
        {
            Random random = new Random();
            int value = random.Next(num);
            return value;
        }
        /// <summary>
        /// Prints the string2 d array.
        /// </summary>
        /// <param name="PlayersArray">The players array.</param>
        public static void PrintString2DArray(string[,] PlayersArray)
        {
            for (int i = 0; i < PlayersArray.GetLength(0); i++)
            {
                for (int j = 0; j < PlayersArray.GetLength(1); j++)
                    Console.Write(PlayersArray[i, j]);
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Cards the array.
        /// </summary>
        /// <param name="Suits">The suits.</param>
        /// <param name="Cards">The cards.</param>
        /// <param name="Rank">The rank.</param>
        public static void CardArray(String[] Suits, String[,] Cards, String[] Rank)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    Cards[i, j] = Suits[i] + "-" + Rank[j];
                }

            }
        }
        /// <summary>
        /// Shufflings the cards.
        /// </summary>
        /// <param name="CardsArray">The cards array.</param>
        public static void ShufflingCards(String[,] CardsArray)
        {
            int row1, row2, column1, column2;
            for (int i = 0; i < 52; i++)
            {
                row1 = RandomValues(CardsArray.GetLength(0));
                column1 = RandomValues(CardsArray.GetLength(1));
                row2 = RandomValues(CardsArray.GetLength(0));
                column2 = RandomValues(CardsArray.GetLength(1));
                Swap(CardsArray, row1, column1, row2, column2);
            }
        }
        /// <summary>
        /// Swaps the specified cards array.
        /// </summary>
        /// <param name="CardsArray">The cards array.</param>
        /// <param name="row1">The row1.</param>
        /// <param name="column1">The column1.</param>
        /// <param name="row2">The row2.</param>
        /// <param name="column2">The column2.</param>
        public static void Swap(string[,] CardsArray, int row1, int column1, int row2, int column2)
        {
            string temp = CardsArray[row1, column1];
            CardsArray[row1, column1] = CardsArray[row2, column2];
            CardsArray[row2, column2] = temp;
        }
        /// <summary>
        /// Distributings the cards.
        /// </summary>
        /// <param name="Cards">The cards.</param>
        /// <param name="Players">The players.</param>
        public static void DistributingCards(string[,] Cards, string[,] Players)
        {
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 9; j++)
                    Players[i, j] = Cards[i, j];
        }


    }
}

