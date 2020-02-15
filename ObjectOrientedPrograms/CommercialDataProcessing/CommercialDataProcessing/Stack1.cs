using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms.CommercialDataProcessing
{
    class Stack1
    {
        public Node2 top;
        public int length;
        public void Push(String info)
        {
            Node2 node = new Node2();
            node.Data = info;
            top = node;
            length++;
        }
        public String Pop()
        {
            String result = top.Data;
            top = top.Link;
            length--;
            return result;
        }
        public int Size()
        {
            return length;
        }
        public String Peek()
        {
            return top.Data;
        }
        public Boolean IsEmpty()
        {
            if (length == 0)
            {
                //Console.WriteLine("stack is empty");
                return true;
            }
            else
                return false;
        }
        public void PrintStack()
        {
            Node2 n = top;
            while (n != null)
            {
                Console.WriteLine(n.Data);
                n = n.Link;

            }

        }
    }
}
