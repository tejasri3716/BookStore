//--------------------------------------------------------------------------------------------------------------------
// <copyright file=Queue.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace ObjectOrientedPrograms.CommercialDataProcessing
{
    using System;

    /// <summary>
    /// Queue class used for adding and deleting shares from Queue
    /// </summary>
    class Queue
    {
        public Node front;
        public Node rear;
        private int length;

        /// <summary>
        /// return Size
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            Console.WriteLine(length);
            return length;
        }
        /// <summary>
        /// Determines whether queue is empty.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance is empty; otherwise, <c>false</c>.
        /// </returns>
        public Boolean IsEmpty()
        {
            return length == 0;
        }
        /// <summary>
        /// Prints the queue.
        /// </summary>
        public void PrintQueue()
        {
            Node current = front;
            if (IsEmpty())
            {
                return;
            }
            else
            {
                while (current != null)
                {
                    Console.WriteLine(current.Data);
                    current = current.Link;
                }
            }
        }
        /// <summary>
        /// return first element in queue
        /// </summary>
        /// <returns></returns>
        public String First()
        {
            if (IsEmpty())
            {
                return default;
            }
            else
            {
                return front.Data;
            }
        }

        /// <summary>
        /// return last element in queue
        /// </summary>
        /// <returns></returns>
        public String Last()
        {
            if (IsEmpty())
            {
                return default;
            }
            else
            {
                return rear.Data;
            }
        }

        /// <summary>
        /// Enqueues the specified information.
        /// </summary>
        /// <param name="info">The information.</param>
        public void Enqueue(String info)
        {
            Node node = new Node();
            node.Data = info;
            if (IsEmpty())
            {
                front = node;
            }
            else
            {
                rear.Link = node;
            }
            rear = node;
            length++;
        }
        /// <summary>
        /// Dequeues the first inserted element
        /// </summary>
        /// <returns></returns>
        public String Dequeue()
        {
            if (IsEmpty())
            {
                return default;
            }
            String result = front.Data;
            front = front.Link;
            if (front == null)
            {
                rear = null;
            }
            length--;
            return result;
        }
    }
}
