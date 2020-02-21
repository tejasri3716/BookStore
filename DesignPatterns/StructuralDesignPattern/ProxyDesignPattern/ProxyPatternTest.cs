using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralDesignPattern.ProxyDesignPattern
{
    public class ProxyPatternTest
    {
        public static void Test()
        {
            ICommandExecutor executor = new CommandExecutorProxyPattern("tejasri", "tejsri@3716");
            try
            {
                executor.RunCommand("ipconfig");
                executor.RunCommand(" rm -rf abc.pdf");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception Message::" + e.Message);
            }
        }
    }
}
