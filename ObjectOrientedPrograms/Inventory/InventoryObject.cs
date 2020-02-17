//--------------------------------------------------------------------------------------------------------------------
// <copyright file=InventoryObject.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace ObjectOrientedPrograms.Inventory
{
    using ObjectOrientedPrograms.InventoryManagement;
    using System;

    /// <summary>
    /// Inventory Object class for reading  and deserializing inventory
    /// </summary>
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
