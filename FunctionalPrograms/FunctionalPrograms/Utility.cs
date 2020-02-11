using System;
using System.Collections.Generic;
using System.Text;

namespace FuctionalPrograms
{
    class Utility
    {
        public static int readInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        public static string readString()
        {
            return Console.ReadLine();
        }
        public static double readDouble()
        {
            return Convert.ToDouble(Console.ReadLine());

        }
        public static bool readBoolean()
        {
            return bool.Parse(Console.ReadLine());
        }
    }
}
