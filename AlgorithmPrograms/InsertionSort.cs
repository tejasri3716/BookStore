using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class InsertionSort
    {
        public static void Sort()
        {
            Console.Write("enter number of strings :");
            int n = Utility.readInt();
            String[] array=new String[n];
            String temp;
            int j;
            Console.WriteLine("enter elements of an array");
            for(int i=0;i<array.Length;i++)
            {
                array[i] = Utility.readString().ToLower();
            }
            for(int i=1;i<array.Length;i++)
            {
                temp = array[i];
                j = i;
                while ((j >0) && (array[j-1].CompareTo(temp) > 0))
                {
                    
                    array[j] = array[j-1];
                    j=j-1;
                }
                array[j] = temp;
            }
            Console.WriteLine("After sorting the strings are :");
            for(int i=0;i<array.Length;i++)
            {
                Console.WriteLine(array[i] +" ");
            }
        }
    }
}
