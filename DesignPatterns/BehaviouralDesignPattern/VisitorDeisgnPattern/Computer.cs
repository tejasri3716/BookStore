//--------------------------------------------------------------------------------------------------------------------
// <copyright file="Computer.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.BehaviouralDesignPattern.VisitorDeisgnPattern
{
    using System.Collections.Generic;

    /// <summary>
    /// Computer class implements IComputerPart interface 
    /// </summary>
    /// <seealso cref="DesignPatterns.BehaviouralDesignPattern.VisitorDeisgnPattern.IComputerPart" />
    public class Computer : IComputerPart
    {
        /// <summary>
        /// The parts
        /// </summary>
        private List<IComputerPart> parts;

        /// <summary>
        /// Initializes a new instance of the <see cref="Computer"/> class.
        /// </summary>
        public Computer()
        {
            this.parts = new List<IComputerPart> { new Mouse(), new Keyboard(), new Monitor() };
        }

        /// <summary>
        /// Accepts the specified computer part visitor.
        /// </summary>
        /// <param name="computerPartVisitor">The computer part visitor.</param>
        public void Accept(IComputerPartVisitor computerPartVisitor)
        {
            foreach (var part in this.parts)
            {
                part.Accept(computerPartVisitor);
            }

            computerPartVisitor.Visit(this);
        }
    }
}