using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DataStructures
{
    class HashMapUsingLinkedList
    {
        public static void hashMap()
        {
            HashMap1 hm = new HashMap1();
            FileStream fsr = new FileStream(@"C:\Users\BridgeLabz\source\repos\InputNum.txt", FileMode.Open, FileAccess.Read,
            FileShare.Read);
            StreamReader sr = new StreamReader(fsr);
            String input = sr.ReadLine();
            string[] str = input.Split(" ");
            int[] array=new int[str.Length];
            /*   int[] nums = Array.ConvertAll(input.Split(" "), int.Parse);*/
            for (int i = 0; i < str.Length; i++)
            {

                /*Console.Write(str[i]);*/
                array[i] = int.Parse(str[i]);
            }
            Array.Sort(array);
            for(int i=0;i<array.Length;i++)
            {
                hm.Hashing(array[i]);
                hm.PrintList();

            }

        }



    }
}
    


    
