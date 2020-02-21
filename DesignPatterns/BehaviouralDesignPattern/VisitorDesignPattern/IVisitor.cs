//--------------------------------------------------------------------------------------------------------------------
// <copyright file="IVisitor.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.BehaviouralDesignPattern.VisitorDesignPattern
{
    public interface IVisitor
    {
        public void Accept(Book book);
        public void Accept(Fruit fruit);
    }
}
