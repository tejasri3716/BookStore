//--------------------------------------------------------------------------------------------------------------------
// <copyright file="Mobile.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.FacadeDesignPattern
{
    using System;

    /// <summary>
    /// Mobile class implements IShopping interface
    /// </summary>
    /// <seealso cref="DesignPatterns.FacadeDesignPattern.IShopping" />
    public class Mobile : IShopping
    {
        /// <summary>
        /// Buys the item.
        /// </summary>
        public void BuyItem()
        {
            Console.WriteLine("your order of mobile is out for delivery");
        }
    }
}