//--------------------------------------------------------------------------------------------------------------------
// <copyright file="IObserver.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.BehaviouralDesignPattern.VisitorDeisgnPattern
{
    using System;
    public class ComputerPartDisplayVisitor : IComputerPartVisitor
    {
        public void Visit(Computer computer)
        {
          Console.WriteLine("Displaying Computer.");
        }
        public void Visit(Mouse mouse)
        {
          Console.WriteLine("Displaying Mouse.");
        }
        public void Visit(Keyboard keyboard)
        {
          Console.WriteLine("Displaying Keyboard.");
        }
        public void Visit(Monitor monitor)
        {
          Console.WriteLine("Displaying Monitor.");
        }
    }
}