using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ObjectOrientedPrograms
{
    class InventoryDetails
    {
        public static void ReadingFromFile()
        {
            string json = "";
            using (StreamReader r = new StreamReader(@"C:\Users\BridgeLabz\source\repos\ObjectOrientedPrograms\Inventory.json"))
            {
                 json = r.ReadToEnd();
            }
            Console.WriteLine(json);
            var items = JsonConvert.DeserializeObject(json);
        }
    }
}
