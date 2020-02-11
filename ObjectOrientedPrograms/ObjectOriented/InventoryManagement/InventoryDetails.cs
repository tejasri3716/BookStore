using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ObjectOrientedPrograms.InventoryManagement;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ObjectOrientedPrograms
{
    public class InventoryDetails
    {
        public void ReadingFromFile()
        {
            try
            {
                string json = @"C:\Users\BridgeLabz\source\repos\ObjectOrientedPrograms\InventoryManagement\Inventory.json";
                /* var jsonfile = File.ReadAllText(json);
                 var obj = JObject.Parse(jsonfile);
                 JArray jArray = (JArray)obj["Rices"];
                 if (obj != null)
                 {
                     foreach (var rice in jArray)
                     {
                         Console.WriteLine("Rice variety:" + rice["name"].ToString());
                         Console.WriteLine("price :" + rice["price"].ToString());
                         Console.WriteLine("weight :" + rice["weight"].ToString());
                     }
                     JArray jArray1 = (JArray)obj["Pulses"];
                     foreach (var pulses in jArray1)
                     {
                         Console.WriteLine("Pulses variety :" + pulses["name"].ToString());
                         Console.WriteLine("Price :" + pulses["price"].ToString());
                         Console.WriteLine("Weight :" + pulses["weight"].ToString());
                     }
                     JArray jArray2 = (JArray)obj["Wheats"];
                     foreach (var wheats in jArray2)
                     {
                         Console.WriteLine("Wheats variety :" + wheats["name"].ToString());
                         Console.WriteLine("price :" + wheats["price"].ToString());
                         Console.WriteLine("weight :" + wheats["weight"].ToString());
                     }
                 }*/
                String jsonfiletext = Utility.ReadFile(json);
                Model modeldata = Utility.Deserializing(jsonfiletext);
                Utility.Display(modeldata);
                InventoryManagement1 im = new InventoryManagement1();
                im.inventoryManagement(modeldata);
                Utility.Display(modeldata);
                Utility.Serializing(modeldata, json);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }

        }
    }
}














/* using (StreamReader r = new StreamReader(@"C:\Users\BridgeLabz\source\repos\ObjectOrientedPrograms\Inventory.json"))*/
/* {
      *//*json = r.ReadToEnd();*//*
 }
 Console.WriteLine(json);
 var items = JsonConvert.DeserializeObject(json);*/
