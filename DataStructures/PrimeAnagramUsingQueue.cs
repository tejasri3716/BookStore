using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class PrimeAnagramUsingQueue
    {
        public static void PrimeUsingQueue()
        {
            Queue1<int> q = new Queue1<int>();
            Console.WriteLine("enter range of numbers to print prime anagrams");
            int num = Utility.readInt();
            int[] array = Utility.Array(Utility.PrimeNumbers(num));
            for(int i=0;i<array.Length;i++)
            {
                for(int j=i+1;j<array.Length;j++)
                {
                    if(Utility.IsAnagram(array[i],array[j]))
                    {
                        q.Enqueue(array[i]);
                    }
                }
            }
            while (!q.IsEmpty())
            {
                Console.WriteLine(q.Dequeue());
            }
        }
    }
}
