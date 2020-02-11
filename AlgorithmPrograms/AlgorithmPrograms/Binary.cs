using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class Binary
    {
        public static void CallingMethods()
        {
            Console.Write("enter a number to convert to return binary string:");
            int num = Utility.readInt();
            ConvertBinary(num);
            SwapNibbles(num);
           
        }
        public static void ConvertBinary(int number)
        {
            //int[] binary = new int[20];
            String s = "";
          // int index = 0;
            while (number > 0)
            {
                int bin = number % 2;
                number = number / 2;
                s = bin + s;
            }
            Console.WriteLine("binary number of" + number + "is :" + s);
            while (s.Length % 4 != 0)
            {
                s += 0;
            }
            Console.WriteLine("binary number of" + number + "is :" + s);


         }
        public static void SwapNibbles(int num)
        {
            int number = (num & 0x0F) << 4 | (num & 0xF0) >> 4;
            Console.WriteLine(number);
            ConvertBinary(number);

        }
        
    }
}
