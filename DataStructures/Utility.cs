using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataStructures
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

      /*  internal static int readInt(TextReader reader)
        {
            return Convert.ToInt32(Console.ReadLine());
        }
*/
        public static bool readBoolean()
        {
            return bool.Parse(Console.ReadLine());
        }
        public static String[] BubbleSortString(String[] array, int n)
        {
            String temp = "";
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;

                    }
                }
            }
            return array;

        }
    }
}
