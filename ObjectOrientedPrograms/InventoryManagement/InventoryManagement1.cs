//--------------------------------------------------------------------------------------------------------------------
// <copyright file=InventoryManagement1.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------

namespace ObjectOrientedPrograms.InventoryManagement
{
    using System;

    class InventoryManagement1
    {
        public void inventoryManagement(Model model)
        {
            Console.WriteLine("1.Adding to Rice ");
            Console.WriteLine("2.Adding to Pulses ");
            Console.WriteLine("3.Adding to Wheats ");
            Console.WriteLine("4.Removing rice item");
            Console.WriteLine("5.Removing wheat item");
            Console.WriteLine("6.Removing pulse item");
            Console.WriteLine("7.Update an item");
            Console.WriteLine("enter any option to get executed");
            int option = Utility.readInt();
            switch (option)
            {
                case 1:
                    Utility.AddRice(model);
                    break;
                case 2:
                    Utility.AddWheats(model);
                    break;
                case 3:
                    Utility.AddPulses(model);
                    break;
                case 4:
                    Utility.RemoveItemRice(model);
                    break;
                case 5:
                    Utility.RemoveItemWheat(model);
                    break;
                case 6:
                    Utility.RemoveItemPulses(model);
                    break;
                case 7:
                    Utility.UpdateData(model);
                    break;
                default:
                    Console.WriteLine("enter correct option");
                    break;
            }
            Utility.Display(model);


        }
    }
}
