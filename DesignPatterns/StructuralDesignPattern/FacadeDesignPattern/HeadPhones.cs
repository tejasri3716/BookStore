//--------------------------------------------------------------------------------------------------------------------
// <copyright file="HeadPhones.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.FacadeDesignPattern
{
    using System;

    /// <summary>
    /// HeadPhones class implements IShopping Interface
    /// </summary>
    /// <seealso cref="DesignPatterns.FacadeDesignPattern.IShopping" />
    public class HeadPhones : IShopping
    {
        /// <summary>
        /// Buys the item.
        /// </summary>
        public void BuyItem()
        {
            Console.WriteLine("your order of head phones is out for delivery");
        }
    }
}