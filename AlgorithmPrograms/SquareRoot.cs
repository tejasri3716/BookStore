using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class SquareRoot
    {
        public static void findSquareRoot()
        {
            Console.Write("enter a number to find square root:");
            double c = Utility.readDouble();
            double epsilon = 1.0e-15;
            double t = c;
            while(Math.Abs(t-c/t)>epsilon*t)
            {
                t = (c / t + t) / 2.0;
            }
            Console.WriteLine("square root of"+c+"is : "+t);
        }
    }
}
