using System;
using System.Collections.Generic;
using System.Text;

namespace FuctionalPrograms
{
    class Distance
    {
      public static void findDistance()
        {
            Console.Write("enter x value:");
            int x = Utility.readInt();
            Console.Write("enter y value:");
            int y = Utility.readInt();
            double distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            Console.WriteLine("distance between (" + x + ","+y + ")to(0,0)=" + distance);
            Console.WriteLine("");

        }
    }
}
