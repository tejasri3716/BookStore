using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms.CommercialDataProcessing
{
    class Queue1
    {
        public Node2 front;
        public Node2 rear;
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
            Node2 current = front;
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
            Node2 node = new Node2();
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
