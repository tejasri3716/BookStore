//--------------------------------------------------------------------------------------------------------------------
// <copyright file="Laptop.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.FacadeDesignPattern
{
    using System;

    /// <summary>
    /// Laptop class implements IShopping interface
    /// </summary>
    /// <seealso cref="DesignPatterns.FacadeDesignPattern.IShopping" />
    public class Laptop : IShopping
    {
        /// <summary>
        /// Buys the item.
        /// </summary>
        public void BuyItem()
        {
            Console.WriteLine("your order for laptop is out for delivery");
        }
    }
}