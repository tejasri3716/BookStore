using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class PrimeNumber
    {
        public void IsPrime()
        {
            int startVal, endVal, number, j;
            Console.WriteLine("enter starting value in range");
            startVal = Utility.readInt();
            Console.WriteLine("enter ending value in range");
            endVal = Utility.readInt();
            for(number=startVal;number<=endVal;number++)
            {
                for(j=2;number%j>0;j++)
                {
                }
                if (j == number)
                    Console.WriteLine(number + "is a prime number");
            }
        }
    }
}
