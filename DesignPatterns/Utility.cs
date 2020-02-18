using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
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
