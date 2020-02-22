//--------------------------------------------------------------------------------------------------------------------
// <copyright file="IComputerPartVisitor.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.BehaviouralDesignPattern.VisitorDeisgnPattern
{
    /// <summary>
    /// IComputerPartVisitor interface consists of abstract method Visit to visit every object
    /// </summary>
    public interface IComputerPartVisitor
    {
        /// <summary>
        /// Visits the specified computer.
        /// </summary>
        /// <param name="computer">The computer.</param>
        public void Visit(Computer computer);

        /// <summary>
        /// Visits the specified mouse.
        /// </summary>
        /// <param name="mouse">The mouse.</param>
        public void Visit(Mouse mouse);

        /// <summary>
        /// Visits the specified keyboard.
        /// </summary>
        /// <param name="keyboard">The keyboard.</param>
        public void Visit(Keyboard keyboard);

        /// <summary>
        /// Visits the specified monitor.
        /// </summary>
        /// <param name="monitor">The monitor.</param>
        public void Visit(Monitor monitor);
    }
}