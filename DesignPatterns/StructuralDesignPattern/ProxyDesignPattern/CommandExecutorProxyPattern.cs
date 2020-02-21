//--------------------------------------------------------------------------------------------------------------------
// <copyright file="CommandExecutorProxyPattern.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.StructuralDesignPattern.ProxyDesignPattern
{
    using System;

    /// <summary>
    /// CommandExecutorProxyPattern class is the Real class in Proxy Design Pattern
    /// </summary>
    /// <seealso cref="DesignPatterns.StructuralDesignPattern.ICommandExecutor" />
    public class CommandExecutorProxyPattern : ICommandExecutor
    {
        /// <summary>
        /// The admin
        /// </summary>
        private bool isAdmin;

        /// <summary>
        /// The executor
        /// </summary>
        private CommandExecutor executor;

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandExecutorProxyPattern"/> class.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <param name="pwd">The password.</param>
        public CommandExecutorProxyPattern(string user, string pwd)
        {
            if ("tejasri".Equals(user) && "tejasri@3716".Equals(pwd))
            {
                this.isAdmin = true;
            }

            this.executor = new CommandExecutor();
        }

        /// <summary>
        /// Runs the command.
        /// </summary>
        /// <param name="cmd">The command.</param>
        /// <exception cref="Exception">rm command is not allowed for non-admin users.</exception>
        public void RunCommand(string cmd)
        {
            if (this.isAdmin)
            {
                this.executor.RunCommand(cmd);
            }
            else
            {
                if (cmd.Trim().StartsWith("rm"))
                {
                    throw new Exception("rm command is not allowed for non-admin users.");
                }
                else
                {
                    this.executor.RunCommand(cmd);
                }
            }
        }
    }
}