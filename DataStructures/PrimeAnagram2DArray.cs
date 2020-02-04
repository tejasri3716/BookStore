using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class PrimeAnagram2DArray
    {
        public static void PrimeAnagrams()
        {
            int row = 0, column = 0, tot = 100;
            Console.WriteLine("enter the range of the values to get prime anagrams");
            int num = Utility.readInt();
            int[,] array = new int[10, 30];
            int[] temp = Utility.Array(Utility.PrimeNumbers(num));
            for (int i = 0; i < temp.Length; i++)
            {
                for (int j = i + 1; j < temp.Length; j++)
                {
                    if (Utility.IsAnagram(temp[i], temp[j]))
                    {
                        if (temp[i] >= tot)
                        {
                            tot = tot + 100;
                            row++;
                            column = 0;
                        }
                        array[row, column] = temp[i];
                        column++;
                    }
                }
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    Console.Write(array[i, j]+" ");
                }
                Console.WriteLine();
            }
        }

    }
}
