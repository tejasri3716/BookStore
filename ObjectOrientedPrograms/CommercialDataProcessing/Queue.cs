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
       
        public int Size()
        {
            Console.WriteLine(length);
            return length;
        }
        public Boolean IsEmpty()
        {
            return length == 0;
        }
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
