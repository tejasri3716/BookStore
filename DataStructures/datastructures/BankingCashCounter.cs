using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class BankingCashCounter
    {
        Node front;
        static int bankBalance = 160000;
        public static void Customer()
        {
            Queue1<String> q = new Queue1<string>();
            Console.Write("enter number of customers\t");
            int num = Utility.readInt();
            for (int i = 1; i <= num; i++)
            {
                Console.Write("enter name of Customer "+i+"\t");
                String name = Utility.readString();
                q.Enqueue(name);
            }
            q.PrintQueue();
            for (int i = 1; i <= num; i++)
            {
                String s= q.First();
                Console.WriteLine("Customer "+s);
                Console.WriteLine("enter any option to make transactions");
                Console.WriteLine("1.With Drawl");
                Console.WriteLine("2.Deposit");
                int option = Utility.readInt();
                switch (option)
                {
                    case 1:
                        int amount;
                        Console.WriteLine("Enter Amount U Want to Withdraw : ");
                        amount = Utility.readInt();
                        BankBalance(option, amount);
                        q.Dequeue();
                        break;
                    case 2:
                        Console.WriteLine("Enter Amount to Deposit");
                        amount = Utility.readInt();
                        BankBalance(option, amount);
                        q.Dequeue();
                        break;
                    default:
                        Console.WriteLine("enter correct option");
                        break;
                }
            }
            Console.WriteLine("Total Bank Balancce is:" + bankBalance);
        }
        public static void BankBalance(int option, int amount)
        {
            if (option == 1)
            {
                bankBalance -= amount;
            }
            else
            {
                bankBalance += amount;
            }
        }

    }
}
