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

    }
}
