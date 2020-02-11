using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AlgorithmPrograms
{
    class PrimePalindrome
    {
        public static void PrimeNums()
        {
            Console.WriteLine("enter numbers");
            int n = Utility.readInt();
            String pNums = Utility.FindPrimeNumbers(n);
            Console.WriteLine("prime numbers are " + pNums);
          /*  String[] arr = Utility.SplitString(pNums);
            Console.WriteLine("prime anagrams are");
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (Utility.StringContains(arr[i], arr[j]))
                    {
                        Console.WriteLine(arr[i] + " " + arr[j]);
                    }
                }
            }
            return pNums;
*/        }
        public static void IsPalimdrome()
        {
            Console.WriteLine("enter the number to find the prime numbers");
            int n = Utility.readInt();
            Collection<int> c = Utility.PrimeNumberArray(n);

            Boolean b = false;
            Console.WriteLine("prime palindromes are");
            for (int i = 0; i < c.Count; i++)
            {
                if (c[i] > 9)
                {
                    b = CheckPalindrome(c[i]);
                    if (b)
                    {
                        Console.Write(c[i] + ",");
                    }
                    /*else
                    {
                        Console.WriteLine("the given number  " + c[i] + "  is not palindrome");
                    }*/
                }

            }
          /*  Console.WriteLine("prime anagram are: ");
            Console.WriteLine();
            for (int i = 0; i < c.Count - 1; i++)
            {
                if (c[i] > 9)
                {
                    for (int j = i + 1; j < c.Count; j++)
                    {
                        //Console.Write("anagram finding");
                       *//* if (c[j].CompareTo(c[i]) < 0)
                        {
                            Console.WriteLine(c[i] + "are anagram" + c[j]);
                        }
                       *//* 
                        Collection<int> ana = NumToArray(c[i]);
                     foreach (int a in ana)
                     {
                         Console.Write(a);
                     }
                     Console.WriteLine();

                    }
                }
            }
       */ }
        public static Boolean CheckPalindrome(int n)
        {
            int temp = n;
            int sum = 0;
            int r;
            while (n > 0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;
            }
            if (temp == sum)
            {
                return true;
            }
            return false;
        }
        
        public static Collection<int> NumToArray(int n)
        {
            Collection<int> ana = new Collection<int>();
            while (n > 0)
            {
                int rem = n % 10;
                n /= 10;
                ana.Add(rem);
            }
            return ana;
        }
    }
}
