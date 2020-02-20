//--------------------------------------------------------------------------------------------------------------------
// <copyright file="ComputerFactory.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FacadeDesignPattern
{
    class Laptop : IShopping
    {
        public void BuyItem()
        {
            Console.WriteLine("your order for laptop is out for delivery");
        }
    }
}
