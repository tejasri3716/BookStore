//--------------------------------------------------------------------------------------------------------------------
// <copyright file="Keyboard.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.BehaviouralDesignPattern.VisitorDeisgnPattern
{
    /// <summary>
    /// Keyboard class implements IComputerPart interface  and overrides Accept method
    /// </summary>
    /// <seealso cref="DesignPatterns.BehaviouralDesignPattern.VisitorDeisgnPattern.IComputerPart" />
    public class Keyboard : IComputerPart
    {
        /// <summary>
        /// Accepts the specified computer part visitor.
        /// </summary>
        /// <param name="computerPartVisitor">The computer part visitor.</param>
        public void Accept(IComputerPartVisitor computerPartVisitor)
        {
            computerPartVisitor.Visit(this);
        }
    }
}