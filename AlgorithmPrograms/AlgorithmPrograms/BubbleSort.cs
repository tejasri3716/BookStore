using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class BubbleSort
    {
        public static void SortIntegers()
        {
            int[] array;
            int temp;
            Console.Write("enter number of elements to be sorted:");
            int n =Utility.readInt();
            array = new int[n];
            Console.WriteLine("enter elements of an array");
            for(int i=0;i<n;i++)
            {
              array[i] = Utility.readInt();
            }
            for(int i=0;i<array.Length;i++)  //no of rounds
            {
              
            for(int j=0;j<array.Length-1-i;j++)   //compare two adjacent integers
                {
                    if(array[j]>(array[j+1]))
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                
                    }
                }
           Console.Write("\n\nAfter sorting the array appears like : \n");
                for (i = 0; i <array.Length; i++)
                {
                    Console.Write(array[i]+" ");
                   
                }
            }
        }
    }
}
