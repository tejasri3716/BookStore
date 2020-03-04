//--------------------------------------------------------------------------------------------------------------------
// <copyright file="ProxyPatternTest.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.StructuralDesignPattern.ProxyDesignPattern
{
    using System;

    /// <summary>
    /// ProxyPatternTest is a proxy class which is used to instantiate CommandExecutorProxyPattern.
    /// </summary>
    public class ProxyPatternTest
    {
        /// <summary>
        /// Tests this instance.
        /// </summary>
        public static void Test()
        {
            ICommandExecutor executor = new CommandExecutorProxyPattern("tejasri", "tejasri@3716");
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
