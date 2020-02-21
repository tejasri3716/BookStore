using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace DesignPatterns.StructuralDesignPattern.ProxyDesignPattern
{
    class CommandExecutor : ICommandExecutor
    {
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
