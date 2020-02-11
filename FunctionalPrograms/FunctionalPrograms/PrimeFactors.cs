using System;
using System.Collections.Generic;
using System.Text;

namespace FuctionalPrograms
{
    class PrimeFactors
    {
       public static void primeFactors()
        {
            Console.WriteLine("enter any number");
            int num = Utility.readInt();
            Console.WriteLine("prime factor of number" + num);
            for(int i=2;i*i<num;i++)
            {
             while(num%i==0)
                {
                    Console.WriteLine(i + "");
                    num = num / i;
                }
            }
            if(num>2)
            {
                Console.WriteLine(num);
            }
        }
    }
}
