//--------------------------------------------------------------------------------------------------------------------
// <copyright file="IComputerPart.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.BehaviouralDesignPattern.VisitorDeisgnPattern
{
    /// <summary>
    /// IComputerPart interface consists of abstract method Accept
    /// </summary>
    public interface IComputerPart
    {
        /// <summary>
        /// Accepts the specified computer part visitor.
        /// </summary>
        /// <param name="computerPartVisitor">The computer part visitor.</param>
        public void Accept(IComputerPartVisitor computerPartVisitor);
    }
}