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
        public static string Writefile(string path, Object r)
        {
            var s = JsonConvert.SerializeObject(r, Formatting.Indented);
            /*var writter = new StreamWriter(path);
            writter.Write(jsonwrite);*/
            String json = path;
            File.WriteAllText(json, s);
            Console.WriteLine(s);
            return "";
        }
        public static string ReadFile(string path)
        {
            try
            {
                string jsonfile = File.ReadAllText(path);
               /* Model obj = JsonConvert.DeserializeObject<Model>(jsonfile);
                Console.WriteLine(obj);*/
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
            return "";
        }
    }
}
