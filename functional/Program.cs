using System;

namespace FuctionalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.ReplaceString");
            Console.WriteLine("2.FlipCoin");
            Console.WriteLine("3.LeapYear");
            Console.WriteLine("4.PowerOf2");
            Console.WriteLine("5.HarmonicNumber");
            Console.WriteLine("6.PrimeFactors");
            Console.WriteLine("7.TwoDimensionalArray");
            Console.WriteLine("8.SumOfTriplets");
            Console.WriteLine("9.Distance");
            Console.WriteLine("10.Quadratic");
            Console.WriteLine("11.WindChill");
            Console.WriteLine("12.Gambler");
            Console.WriteLine("13.Stopwatch1");
            Console.WriteLine("16.VendingMachine");
            Console.WriteLine("enter an option to be executed");
            int option = Utility.readInt();
            switch(option)
            {
                case 1:
                    ReplaceString.Replace();
                    break;
                case 2:
                    FlipCoin.headsAndTails();
                    break;
                case 3:
                    LeapYear.isLeapYear();
                    break;
                case 4:
                    PowerOf2.powerOfnum();
                    break;
                case 5:
                    HarmonicNumber.harmonicNumber();
                    break;
                case 6:
                    PrimeFactors.primeFactors();
                    break;
                case 7:
                    TwoDimesionalArray.twoDimensionalIntArray();
                    TwoDimesionalArray.twoDimensionalDoubleArray();
                    TwoDimesionalArray.twoDimensionalBooleanArray();
                    break;
                case 8:
                    SumOfTriplets.findTriplets();
                    break;
                case 9:
                    Distance.findDistance();
                    break;
                case 10:
                    Quadratic.findRoots();
                    break;
                case 11:
                    WindChill.findTemperature();
                    break;
                case 12:
                    Gambler.GamblerSimulator();
                    break;
                case 13:
                    Stopwatch1.UseStopwatch();
                    break;
                case 16:
                    VendingMachine.countNotes();
                    break;
            }
        }
    }
}
