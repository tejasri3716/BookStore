using System;
using System.Collections.Generic;
using System.Text;

namespace FuctionalPrograms
{
    class HarmonicNumber
    {
        public static void harmonicNumber()
        {
            Console.WriteLine("enter a number");
            int n = Utility.readInt();
            double sum =0.0;
            for(int i=1;i<=n;i++)
            {
                sum = sum + (double)1 / i;
                Console.WriteLine("Nth harmonic number value is:"+sum);
            }
        }
    }
}
