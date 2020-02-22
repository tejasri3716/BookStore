//--------------------------------------------------------------------------------------------------------------------
// <copyright file="ICommand.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.BehaviouralDesignPattern.MediatorDesignPattern
{
    /// <summary>
    /// ICommand interface consists of abstract method land
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// Lands this instance.
        /// </summary>
        public void Land();
    }
}