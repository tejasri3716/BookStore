//--------------------------------------------------------------------------------------------------------------------
// <copyright file="Fruit.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralDesignPattern.VisitorDesignPattern
{
    public class Fruit : IStore
    {
        public string FruitName { get; set; }
        public int Price { get; set; }
        public void Visit(IVisitor visitor)
        {
            visitor.Accept(this);
        }
    }
}
