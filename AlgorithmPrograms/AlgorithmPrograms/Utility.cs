using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Text;

namespace AlgorithmPrograms
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
        public static bool readBoolean()
        {
            return bool.Parse(Console.ReadLine());
        }
        public static String[] BubbleSortString(String[] array,int n)
        {
            String temp = "";
            for(int i=0;i<n;i++)
            {
                for(int j=0;j<n-1-i;j++)
                {
                    if(array[j].CompareTo(array[j+1])>0)
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;

                    }
                }
            }
            return array;

        }
        static Collection<int> coll = new Collection<int>();
        public static String FindPrimeNumbers(int n)
        {
            String nums = "";
            for (int i = 1; i <= n; i++)
            {
                int count = 0;
                for (int j = i; j >= 1; j--)
                {
                    if (i % j == 0)
                    {
                        count += 1;
                    }
                }
                if (count == 2)
                {
                    coll.Add(i);
                    nums = nums + " " + i;
                }
            }
            return nums;
        }
        public static Collection<int> PrimeNumberArray(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                int count = 0;
                for (int j = i; j >= 1; j--)
                {
                    if (i % j == 0)
                    {
                        count += 1;
                    }
                }
                if (count == 2)
                {
                    coll.Add(i);
                }
            }
            return coll;
        }


    }
}
