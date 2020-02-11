using System;
using System.Collections.Generic;
using System.Text;

namespace FuctionalPrograms
{
    class LeapYear
    {
        public static void isLeapYear()
        {
            int year;
            Boolean result = false;
            Console.WriteLine("enter year to check whether it is a leap year or not");
            year = Utility.readInt();
            if (year > 1000)
            {
                if ((year % 400 == 0) || ((year % 4 == 0) && (year % 100 != 0)))
                {
                    result = true;
                }
                else
                result = false;
            }
            if (result)
            {
                Console.WriteLine(year + "is a leap year");
            }
            else
            Console.WriteLine(year + "is not a leap year");
         
        }

    }
}
