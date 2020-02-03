﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.UnOrderedListTest\n2.OrderedListTest\n3.BalancedParanthesis \n4.BankingCashCounter\n5.PalindromeUsingDeQueue\n6.PrimeNumber");
            int option = Utility.readInt();
            switch(option)
            {
                case 1:
                    UnOrderedListTest.ReadInputFromFile();
                    break;
                case 2:
                    OrderedListTest.Test();
                    break;
                case 3:
                    BalancedParanthesis.balancedParanthesis();
                    break;
                case 4:
                    BankingCashCounter.Customer();
                    break;
                case 5:
                    PalindromeUsingDeQueue.IsPalindrome();
                    break;
                case 6:
                    PrimeNumber.Prime();
                    break;
            }
        }
        }
}
