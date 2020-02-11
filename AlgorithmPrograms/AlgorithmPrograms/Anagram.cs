using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class Anagram
    {
        public static void IsAnagram()
        {
            Console.Write("enter first string :");
            String str = Utility.readString();
            Console.Write("enter second string :");
            String str2 = Utility.readString();
            String s1 = str.Replace("\\s", "");
            String s2 = str2.Replace("\\s", "");
            Boolean status = false;
            if(s1.Length!=s2.Length)
            {
                status = false;
            }
            else
            {
                char[] array1 = s1.ToLower().ToCharArray();
                char[] array2 = s2.ToLower().ToCharArray();
                Array.Sort(array1);
                Array.Sort(array2);
                /*Console.Write(array1);
                Console.WriteLine(array2);*/

                for (int i = 0; i < array1.Length; i++)
                {
                    if (array1[i] == array2[i])
                    {
                        status = true;
                    }
                    else
                    {
                        status = false;
                    }
                }
                    if (status)
                    {
                        Console.WriteLine("string " + s1 + " and " + s2 + " are anagrams of each other");
                    }
                    else
                    {
                        Console.WriteLine("string " + s1 + " and " + s2 + " are not anagrams of each other");

                    }

            }
        }


    }
}
