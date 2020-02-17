using ObjectOrientedPrograms.InventoryManagement;
using System;
using System.Collections.Generic;
using System.Text;


namespace ObjectOrientedPrograms.Inventory
{
    class InventoryObject
    {
        public void ReadingFromFile()
        {
            try
            {
                string json = @"C:\Users\BridgeLabz\source\repos\ObjectOrientedPrograms\InventoryManagement\Inventory.json";
                String jsonfiletext = Utility.ReadFile(json);
                Model modeldata = Utility.Deserializing(jsonfiletext);
                Utility.Display(modeldata);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }
        }
    }
}
