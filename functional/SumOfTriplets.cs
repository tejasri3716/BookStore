using System;
using System.Collections.Generic;
using System.Text;

namespace FuctionalPrograms
{
    class SumOfTriplets
    {
        public static void findTriplets()
        {
            Console.WriteLine("enter number of elements in an array:");
            int num = Utility.readInt();
            int[] array = new int[num];
            int size = array.Length;
            Boolean found = true;
            int count = 0;
          for(int i=0;i<size;i++)
            {
                Console.WriteLine("enter" + i + "element");
                array[i] = Utility.readInt();
                         }
            Console.WriteLine("\n");

            for (int i=0;i<size-2;i++)
            {
                for(int j=i+1;j<size-1;j++)
                {
                    for(int k=j+1;k<size;k++)
                    {
                        if(array[i]+array[j]+array[k]==0)
                        {
                            Console.Write(array[i]);
                            Console.Write(" ");
                            Console.Write(array[j]);
                           Console.Write(" ");
                            Console.Write(array[k]);
                            Console.WriteLine("\n");
                            found = true;
                            count++;
                        }
                        
                    }
                }
            }
            Console.WriteLine("total no of triplets found:"+count);
          if(found==false)
            {
                Console.WriteLine("triplets not found");
                Console.Write(" ");
            }


        }
    }
}
