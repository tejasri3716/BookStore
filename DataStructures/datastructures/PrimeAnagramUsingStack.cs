using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class PrimeAnagramUsingStack
    {
        public static void PrimeAnagramsUsingStack()
        {
            Stack1<int> stack = new Stack1<int>();
            int[] array = Utility.Array(Utility.PrimeNumbers(1000));
            Console.WriteLine(array);
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (Utility.IsAnagram(array[i], array[j]))
                    {
                        stack.Push(array[i]);
                    }
                }
            }
            Console.WriteLine("printing");
            while (!stack.IsEmpty())
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }

}

