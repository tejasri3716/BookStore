using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class Stack1<T>
    {
        private Node top;
        private int length;
        public void Push(T info)
        {
            Node node = new Node(info);
            node.link = top;
            top = node;
            length++;
        }
        public T Pop()
        {
            T result = (T)top.info;
            top = top.link;
            length--;
            return result;
        }
        public int Size()
        {
            return length;
        }
        public T Peek()
        {
            return (T)top.info;
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
            Node n = top;
            while (n != null)
            {
                Console.WriteLine(n.info);
                n = n.link;

            }

        }
    }
}

