using System;
using System.Collections.Generic;
using System.Text;

namespace FuctionalPrograms
{
    class VendingMachine
    {
        public static void countNotes()
         {
            Console.WriteLine("enter amount to be returned by the vendor");
            int amount = Utility.readInt();
            int[] notes = new int[] { 1000, 500, 100, 50, 10, 5, 2, 1 };
            int[] noteCount = new int[8];
            int n = noteCount.Length;
            int count = 0;
            for (int i = 0; i <n; i++)
            {
             if(amount>=notes[i])
                {
                    noteCount[i] = amount / notes[i];
                    amount = amount - noteCount[i]*notes[i];
                    count = count + noteCount[i];
              }
            }
            Console.WriteLine("Notes that would given in the Change ");
            for(int i=0;i<n;i++)
            {
               if(notes[i]!=0)
                {
                   
                    Console.WriteLine(notes[i] + ":" + noteCount[i]);
                    

                }

            }
            Console.WriteLine("total no of notes " + count);
        }
    }

}
