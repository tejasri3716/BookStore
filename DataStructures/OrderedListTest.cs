// --------------------------------------------------------------------------------------------------------------------
// <copyright file=OrderedListTest.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DataStructures
{
    class OrderedListTest
    {
        /*public static void ReadingNumbersFromFile()
        {
            OrderedList<int> ol= new OrderedList<int>();
            string[] lines = File.ReadAllLines(@"C:\Users\BridgeLabz\source\repos\InputNum.txt");
            Console.WriteLine("Contents of Input.txt");
            int[] num = new int[lines.Length];
            for(int i=0;i<num.Length;i++)
            {
                num[i] = int.Parse(lines[i]);
                Console.WriteLine(num);
                ol.AddList(num[i]);
            }
            Console.WriteLine(ol.Size());

        }*/
       
        public static void Test()
        {
            OrderedList<int> ol = new OrderedList<int>();
            Console.WriteLine("enter how numbers you want to add to the list :");
            int n = Utility.readInt();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("enter the  number");
                ol.AddList(Utility.readInt());
            }

            ol.PrintList();
            Console.WriteLine("enter the number to add or remove");
            int num = Utility.readInt();
            AddOrRemoveFromOrdered(num, ol);
            ol.PrintList();

        }
        public static int AddOrRemoveFromOrdered(int data, OrderedList<int> ol)
        {
            bool presence = ol.Search(data);
            Console.WriteLine(presence);
            if (presence)
            {
                ol.Remove(data);
                Console.WriteLine("removed");
                return data;
            }
            else
            {
                ol.AddList(data);
                Console.WriteLine("added");
            }
            return data;
        }
    }
}
