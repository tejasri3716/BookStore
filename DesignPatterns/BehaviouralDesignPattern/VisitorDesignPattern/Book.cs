//--------------------------------------------------------------------------------------------------------------------
// <copyright file="Book.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.BehaviouralDesignPattern.VisitorDesignPattern
{
    public class Book : IStore
    {
        public string BookName { get; set; }
        public int Price { get; set; }
        public void Visit(IVisitor visitor)
        {
            visitor.Accept(this);
        }
    }
}