//--------------------------------------------------------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns
{
    using System;
    /// <summary>
    /// Utility class consists of logics
    /// </summary>
    class Utility
    {
        public static int ReadInt()
        {
           return Convert.ToInt32(Console.ReadLine());
        }
        public static string ReadString()
        {
            return Console.ReadLine();
        }
        public static double ReadDouble()
        {
            return Convert.ToDouble(Console.ReadLine());
        }
        public static bool ReadBool()
        {
            return Convert.ToBoolean(Console.ReadLine());
        }

    }
}
