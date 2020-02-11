using System;
using System.Collections.Generic;
using System.Text;

namespace FuctionalPrograms
{
    class Coupoun
    {
       
            public static void coupon()
            {
                Console.WriteLine("enter the number");
                int n = Utility.readInt();
                int count = 0, d = 0;
                Random r = new Random();
                ///delcaring array boolean
                Boolean[] b = new Boolean[n];
                Console.WriteLine("distinct numbers are");
                while (d < n)
                {
                    ///Declares val for storing random number
                    int val = Convert.ToInt32(r.Next(0, n));
                    count++;

                    ///to check random number generated is not repeated if so distinct value is incremented
                    if (!b[val])
                    {
                        d++;
                        b[val] = true;
                        Console.Write(val + " ");
                    }
                }
                Console.WriteLine("\ntotally generated random numbers are " + count);
                Console.WriteLine("\ntotal random numbers which are not repeated " + d);
            }
        }
}
