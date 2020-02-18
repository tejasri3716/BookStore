//--------------------------------------------------------------------------------------------------------------------
// <copyright file="Stack.cs" company="Bridgelabz">
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
        /// <summary>
        /// Pushes the specified information.
        /// </summary>
        /// <param name="info">The information.</param>
        public void Push(String info)
        {
            Node node = new Node();
            node.Data = info;
            top = node;
            length++;
        }
        /// <summary>
        /// Pops the last element
        /// </summary>
        /// <returns></returns>
        public String Pop()
        {
            String result = top.Data;
            top = top.Link;
            length--;
            return result;
        }
        /// <summary>
        /// rerurn Size
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            return length;
        }
        /// <summary>
        /// returns top element in stack
        /// </summary>
        /// <returns></returns>
        public String Peek()
        {
            return top.Data;
        }
        /// <summary>
        /// Determines whether this instance is empty.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance is empty; otherwise, <c>false</c>.
        /// </returns>
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
        /// <summary>
        /// Prints the stack.
        /// </summary>
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
