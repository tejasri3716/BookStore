using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class BalancedParanthesis
    {
        static Stack1<char> st = new Stack1<char>();
        
        public static void balancedParanthesis()
        {
           // Stack1<int> st = new Stack1<int>();

            /* for (int i = 0; i < 10; i++)
             {
                 st.Push(i);
             }
             st.PrintStack();
             int s = st.Pop();
             Console.WriteLine("popped element is :" + s);
             int l = st.Size();
             Console.WriteLine(l);
             Boolean s2=st.IsEmpty();
             Console.WriteLine(s2);*/
            String s = "(5+6)∗(7+8)/(4+3)(5+6)∗(7+8)/(4+3)";
            Console.WriteLine("expression is" + s);
            bool check = CheckIfBalanced(s);
            if (check)
            {
                Console.WriteLine("paranthesis are balanced");
            }
            else
            {
                Console.WriteLine("paranthesis are not balanced");
            }
        }
        public static Boolean CheckIfBalanced(String s)
        {

            char[] ch = s.ToCharArray();
            int length = 0;
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == '(')
                {
                  st.Push(ch[i]);
                    length++;
                }
                else if(ch[i]==')')
                {
                    if(length==0)
                    {
                        return false;
                    }
                    char c = st.Pop();
                    length--;
                }

            }
            return st.IsEmpty();
        }
    }
}
