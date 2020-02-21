using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralDesignPattern.ProxyDesignPattern
{
    public class CommandExecutorProxyPattern : ICommandExecutor
    {
        private bool isAdmin;
        private CommandExecutor executor;

        public CommandExecutorProxyPattern(string user, string pwd)
        {
            if ("tejasri".Equals(user) && "tejasri@3716".Equals(pwd)) isAdmin = true;
            executor = new CommandExecutor();
        }
        public void RunCommand(string cmd)
        {
            if (isAdmin)
            {
                executor.RunCommand(cmd);
            }
            else
            {
                if (cmd.Trim().StartsWith("rm"))
                {
                    throw new Exception("rm command is not allowed for non-admin users.");
                }
                else
                {
                    executor.RunCommand(cmd);
                }
            }
        }
    }
}