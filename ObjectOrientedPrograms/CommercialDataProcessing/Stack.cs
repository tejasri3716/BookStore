//--------------------------------------------------------------------------------------------------------------------
// <copyright file=Stack.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace ObjectOrientedPrograms.CommercialDataProcessing
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Stack class used for adding and deleting shares in stack
    /// </summary>
    class Stack
    {
        public Node top;
        public int length;
        public void Push(String info)
        {
            Node node = new Node();
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
            Node n = top;
            while (n != null)
            {
                Console.WriteLine(n.Data);
                n = n.Link;

            }

        }
    }
}
