using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json.Linq;

namespace ObjectOrientedPrograms.InventoryManagement
{
    class Inventory3
    {
        string json = @"C:\Users\BridgeLabz\source\repos\ObjectOrientedPrograms\InventoryManagement\Inventory.json";
        public void FileData()
        {
            string jsonfile = File.ReadAllText(json);
        }
    }
}


