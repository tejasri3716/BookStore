using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class PalindromeUsingDeQueue
    {
        public static void IsPalindrome()
        {
            Console.WriteLine("enter a string to check whether it is palindrome :");
            String s = Utility.readString();
            char[] ch = s.ToCharArray();
            bool result = CheckIfPalindrome(ch);
            if (result)
            {
                Console.WriteLine(s + " is a palindrome");
            }
            else
            {
                Console.WriteLine(s + " is not a palindrome");
            }
        }
        public static Boolean CheckIfPalindrome(char[] ch)
        {
            DeQueue1<char> dq = new DeQueue1<char>();
            for (int i = 0; i < ch.Length; i++)
            {
                dq.AddRear(ch[i]);
            }
            dq.PrintDeQueue();
            int k = 0;
            while (k < ch.Length)
            {
                char c = dq.DeleteRear();
                if (ch[k] != c)
                {
                    return false;
                }
                else
                {
                    Console.WriteLine(ch[k]);
                    k++;
                    return true;
                }
            }
            return dq.IsEmpty();
        }
    }
}
