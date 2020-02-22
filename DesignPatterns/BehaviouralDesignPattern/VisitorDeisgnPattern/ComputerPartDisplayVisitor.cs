//--------------------------------------------------------------------------------------------------------------------
// <copyright file="ComputerPartDisplayVisitor.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.BehaviouralDesignPattern.VisitorDeisgnPattern
{
    using System;

    /// <summary>
    /// ComputerPartDisplayVisitor implements IComputerPartVisitor interface consists of Visit method which 
    /// implements the intent of Visitor Pattern
    /// </summary>
    /// <seealso cref="DesignPatterns.BehaviouralDesignPattern.VisitorDeisgnPattern.IComputerPartVisitor" />
    public class ComputerPartDisplayVisitor : IComputerPartVisitor
    {
        /// <summary>
        /// Visits the specified computer.
        /// </summary>
        /// <param name="computer">The computer.</param>
        public void Visit(Computer computer)
        {
          Console.WriteLine("Displaying Computer.");
        }

        /// <summary>
        /// Visits the specified mouse.
        /// </summary>
        /// <param name="mouse">The mouse.</param>
        public void Visit(Mouse mouse)
        {
          Console.WriteLine("Displaying Mouse.");
        }

        /// <summary>
        /// Visits the specified keyboard.
        /// </summary>
        /// <param name="keyboard">The keyboard.</param>
        public void Visit(Keyboard keyboard)
        {
          Console.WriteLine("Displaying Keyboard.");
        }

        /// <summary>
        /// Visits the specified monitor.
        /// </summary>
        /// <param name="monitor">The monitor.</param>
        public void Visit(Monitor monitor)
        {
          Console.WriteLine("Displaying Monitor.");
        }
    }
}