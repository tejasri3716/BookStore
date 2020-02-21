//--------------------------------------------------------------------------------------------------------------------
// <copyright file="ICommandExecutor.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.StructuralDesignPattern
{
    /// <summary>
    /// ICommandExecutor interface consists of RunCommand Abstract Method
    /// </summary>
    public interface ICommandExecutor
    {
        /// <summary>
        /// Runs the command.
        /// </summary>
        /// <param name="cmd">The command.</param>
        public void RunCommand(string cmd);
    }
}