using System;
using System.Collections.Generic;
using System.Text;

namespace FuctionalPrograms
{
    class PowerOf2
    {
        public static void powerOfnum()
        {
            int n;
            int power = 1;
            Console.WriteLine("enter a number to get power of 2");
            n = Utility.readInt();
            for(int i=0;i<=n;i++)
            {
           Console.WriteLine("2^" + i + "=" +power);
                power = power * 2;
            }
        }
    }
}
