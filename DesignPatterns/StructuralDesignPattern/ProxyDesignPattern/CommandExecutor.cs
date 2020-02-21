//--------------------------------------------------------------------------------------------------------------------
// <copyright file="CommandExecutor.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.StructuralDesignPattern.ProxyDesignPattern
{
    using System;

    /// <summary>
    /// CommandExecutor class implements ICommandExecutor interface
    /// </summary>
    /// <seealso cref="DesignPatterns.StructuralDesignPattern.ICommandExecutor" />
    public class CommandExecutor : ICommandExecutor
    {
        /// <summary>
        /// Runs the command.
        /// </summary>
        /// <param name="cmd">The command.</param>
        public void RunCommand(string cmd)
        {
            /*string strCmdText;
            strCmdText = "COLOR fc";
            Process process = new Process();
            Process.Start("CMD.exe", cmd);*/
            Console.WriteLine("'" + cmd + "' : Command Executed");
            
            // process.WaitForExit();
        }
    }
}
