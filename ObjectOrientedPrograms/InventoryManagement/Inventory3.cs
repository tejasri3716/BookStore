using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace ObjectOrientedPrograms.InventoryManagement
{
    class Inventory3
    {
        string json = @"C:\Users\BridgeLabz\source\repos\ObjectOrientedPrograms\InventoryManagement\Inventory.json";
        public void AddData()
        {
            string jsonfile = File.ReadAllText(json);
            Model obj = JsonConvert.DeserializeObject<Model>(jsonfile);
            Console.WriteLine(obj);
            Console.WriteLine("Serialization");
            Console.WriteLine("1.Adding to Rice File");
            Console.WriteLine("2.Adding to Pulses File");
            Console.WriteLine("3.Adding to Wheats File");
            Console.WriteLine("enter an option to add data into file");
            int option = Utility.readInt();
            switch(option)
            {
                case 1:
                    Console.WriteLine("enter values to get added into json file :");
                    Rices rice = new Rices { Name = Utility.readString(), Price = Utility.readDouble(), Weight = Utility.readDouble(), };
                    obj.Rices.Add(rice);
                    /* String s = JsonConvert.SerializeObject(obj);
                     File.WriteAllText(json,s);
                     Console.WriteLine(s);*/
                    Utility.Writefile(json, obj);
                    break;
                case 2:
                    Console.WriteLine("enter values to get added into json file :");
                    Pulses pulses = new Pulses { Name = Utility.readString(), Price = Utility.readDouble(), Weight = Utility.readDouble() };

                    obj.Pulses.Add(pulses);
                    Utility.Writefile(json, obj);
                    break;
                case 3:
                    Console.WriteLine("enter values to get added into json file :");
                    Wheats wheats = new Wheats { Name = Utility.readString(), Price = Utility.readDouble(), Weight = Utility.readDouble() };

                    obj.Wheats.Add(wheats);
                    Utility.Writefile(json, obj);
                    break;
            }
        }
        public void UpdateData()
        {
            string jsonfile = File.ReadAllText(json);
           // var obj = JObject.Parse(jsonfile);
            /*  JArray jArray = (JArray)obj["Rices"];
              foreach(string s in jArray)
              {
                  Console.WriteLine(s);
              }*/
            //   string[] res = (string[])obj; //convertion object to string array
            /*  string iii = Convert.ToString(item["subjects"]);
              Rices[] rice= JsonConvert.DeserializeObject<Rices[]>(iii);*/
            Rices[] arr = JObject.Parse(jsonfile)["Rices"].ToObject<Rices[]>();
            foreach(var s in arr)
            {
                Console.WriteLine(s);
            }

        }
    }
}


