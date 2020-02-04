using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class Calendar
    {
        public static int day(int month, int day, int year)
        {
            int y = year - (14 - month) / 12;
            int x = y + y / 4 - y / 100 + y / 400;
            int m = month + 12 * ((14 - month) / 12) - 2;
            int d = (day + x + (31 * m) / 12) % 7;
            return d;
        }

        // return true if the given year is a leap year
        public static Boolean isLeapYear(int year)
        {
            if ((year % 4 == 0) && (year % 100 != 0)) return true;
            if (year % 400 == 0) return true;
            return false;
        }

        public static void Calling()
        {
            Console.WriteLine("enter month number ");
            int month = Utility.readInt();
            Console.WriteLine("enter year number");
            int year = Utility.readInt();
            String[] months = { "", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            int[] days = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (month == 2 && isLeapYear(year))
            {
                days[month] = 29;
            }
            Console.WriteLine("   " + months[month] + " " + year);
            Console.WriteLine(" S  M Tu  W Th  F  S");
            Console.WriteLine("------------------------------------");
            int d = day(month, 1, year);

            for (int i = 0; i < d; i++)
                Console.Write("   ");

            for (int i = 1; i <= days[month]; i++)
            {
                Console.Write(i+" ");

                if (((i + d) % 7 == 0) || (i == days[month]))
                    Console.WriteLine();
            }

        }
    }
}
