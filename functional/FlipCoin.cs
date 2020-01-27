using System;
using System.Collections.Generic;
using System.Text;

namespace FuctionalPrograms
{
    class FlipCoin
    {
        public static void headsAndTails()
        {
            Random random = new Random();
            int headCount = 0;
            int tailCount = 0;
            int count = 1;
            Console.WriteLine("enter no of flips");
            int flips=Utility.readInt();
            do
            {
            if(random.NextDouble()<0.5)
                {
                    headCount++;
                }
            else
                {
                    tailCount++;
                 }
                count++;

            } while (count <= flips);

            Console.WriteLine("Total no of heads:" + headCount);
            Console.WriteLine("Total no of tails:" + tailCount);

        }


    }
}
