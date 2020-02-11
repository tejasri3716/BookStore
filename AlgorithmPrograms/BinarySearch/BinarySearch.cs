using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AlgorithmPrograms
{
    class BinarySearch
    {
        public static String[] ReadingFromFile()
        {
            String[] words = System.IO.File.ReadAllLines("C:\\Users\\hariv\\source\\repos\\Input.txt");
            Console.WriteLine("enter a word to search");
            String word = Utility.readString();
            String[] sortedWords = SortWords(words);
            int result = SearchBinary(sortedWords, word);

            if (result == -1)
                Console.WriteLine("Element not present");
            else
                Console.WriteLine("Element found at "
                                + "index " + result);

            return words;
        }
        public static String[] SortWords(String[] ar1)
        {
            String[] arr = new String[ar1.Length];
            for (int i = 0; i < ar1.Length; i++)
            {
                arr[i] = ar1[i].ToLower();
            }
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) > 0)
                    {
                        String t = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = t;
                    }
                }
            }
            return arr;
        }
        static int SearchBinary(String[] arr, String str)
        {
            int res = 0, length = arr.Length - 1;
            while (res <= length)
            {
                int m = res + (length - res) / 2;

                int result = str.CompareTo(arr[m]);
                if (result == 0)
                    return m;
                if (result > 0)
                    res = m + 1;
                else
                    length = m - 1;
            }

            return -1;
        }

    }
}
