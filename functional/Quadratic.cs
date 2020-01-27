using System;
using System.Collections.Generic;
using System.Text;

namespace FuctionalPrograms
{
    class Quadratic
    {
        public static void findRoots()
        {
            Console.Write("enter valu for a:");
            double a = Utility.readDouble();
            Console.Write("enter valu for b:");
            double b= Utility.readDouble();
            Console.Write("enter valu for c:");
            double c= Utility.readDouble();
            double root1, root2, determinant;
            determinant = b * b - 4 * a * c;
            if(a==0)
            {
                Console.WriteLine("the roots are Linear");
            }
            if(determinant>0)
                {
                Console.WriteLine("the roots are real and distinct");
                root1 = (-b + Math.Sqrt(determinant)) / (2 * a);
                root2 = (-b + Math.Sqrt(determinant)) / (2 * a);
                Console.WriteLine("root 1 is:" + root1);
                Console.WriteLine("root 2 is:" + root2);
                }
            if(determinant==0)
            {
                Console.WriteLine("the roots are real and equal");
                root1 =root2= (-b )/ (2 * a);
                Console.WriteLine("root1 is:" + root1);
                Console.WriteLine("root2 is:" + root2);
            }
            else
            {
                Console.WriteLine("roots are imaginary");
                root1 = (-b) /( 2 * a);
                root2 = Math.Sqrt(-determinant) / (2 * a);
                Console.WriteLine("root1 is:" + root1);
                Console.WriteLine("root2 is:" + root2);
            }

            }
        }

    }

