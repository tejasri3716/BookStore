using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class MonthlyPayment
    {
        public static void findMonthlyPayment()
        {
            Console.Write("enter principle loan amount :");
            double principle = Utility.readDouble();
            Console.Write("enter no of years :");
            double year = Utility.readDouble();
            Console.Write("enter rate of intrest :");
            double rate = Utility.readDouble();
            double mothlyIntrestRate = (rate) / (12 * 100);
            double noOfMonths = 12 * year;
            double payment = (principle * mothlyIntrestRate) / (1 - Math.Pow(1 + rate, -noOfMonths));
            double intrest = (payment * noOfMonths) - principle;
            Console.WriteLine("monthly payment=" + payment);
            Console.WriteLine("total intrest=" + intrest);
         }
    }
}
