using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class DayOfWeek
    {
        public static void findDayOfWeek()
        {
            Console.Write("enter month number:");
            int month = Utility.readInt();
            Console.Write("enter year number:");
            int year = Utility.readInt();
            Console.Write("enter date:");
            int day = Utility.readInt();
         int   y0 = year-(14-month) / 12;
         int  x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = month + 12 * ((14-month)/ 12)-2;
         int   d0 = (day + x + 31*m0 / 12) % 7;
            Console.WriteLine("day of the week is" + d0);
       }
   }
}
