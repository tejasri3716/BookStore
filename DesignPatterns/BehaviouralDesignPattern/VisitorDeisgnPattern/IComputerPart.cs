//--------------------------------------------------------------------------------------------------------------------
// <copyright file="IObserver.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.BehaviouralDesignPattern.VisitorDeisgnPattern
{
    public interface IComputerPart
    {
        public void Accept(IComputerPartVisitor computerPartVisitor);
    }
}