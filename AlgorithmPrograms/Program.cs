using System;

namespace AlgorithmPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.VendingMachine");
            Console.WriteLine("2.DayOfWeek");
            Console.WriteLine("3.TemperatureConversion");
            Console.WriteLine("4.MonthlyPayment");
            Console.WriteLine("5.SquareRoot");
            Console.WriteLine("6.Binary");
            Console.WriteLine("7.PermutationsUsingRecursion");
            Console.WriteLine("8.BubbleSort");
            Console.WriteLine("9.InsertionSort");
            Console.WriteLine("10.PrimeNumber");
            Console.WriteLine("11.Anagram");
            Console.WriteLine("12.BinarySearch");
            Console.WriteLine("13.MergeSort1");
            int option = Utility.readInt();
            switch (option)
            {
                case 1:
                    VendingMachine.countNotes();
                    break;
                case 2:
                    DayOfWeek.findDayOfWeek();
                    break;
                case 3:
                    TemperatureConversion.temperatureConversion();
                    break;
                case 4:
                    MonthlyPayment.findMonthlyPayment();
                    break;
                case 5:
                    SquareRoot.findSquareRoot();
                    break;
                case 6:
                    Binary.CallingMethods();
                    break;
                case 7:
                    PermutationUsingRecursion.CallerMethods();
                    break;
                case 8:
                    BubbleSort.SortIntegers();
                    break;
                case 9:
                    InsertionSort.Sort();
                    break;
                case 10:
                    PrimeNumber p = new PrimeNumber();
                    p.IsPrime();
                    break;
                case 11:
                    Anagram.IsAnagram();
                    break;
                case 12:
                    BinarySearch.ReadingFromFile();
                    break;
                case 13:
                    MergeSort1.CallerMethod();
                    break;


            }
        }
    }
}
