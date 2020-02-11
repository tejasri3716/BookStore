using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class Queue1<T>
    {
        private Node front;
        private Node rear;
        private int length;
        public Queue1()
        {
            this.front = null;
            this.rear = null;
            this.length = 0;
        }
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
                    Console.WriteLine(current.info);
                    current = current.link;
                }
            }
        }
        public T First()
        {
            if(IsEmpty())
            {
                return (T)default;
            }
            else
            {
                return (T)front.info;
            }
        }
        public T Last()
        {
            if(IsEmpty())
            {
                return (T)default;
            }
            else
            {
                return (T)rear.info;
            }
        }
        public void Enqueue(T info)
        {
            Node node = new Node(info);
            if (IsEmpty())
            {
                front = node;
            }
            else
            {
                rear.link = node;
            }
            rear = node;
            length++;
        }
        public T Dequeue()
        {
            if (IsEmpty())
            {
                return (T)default;
            }
            T result = (T)front.info;
            front = front.link;
            if (front == null)
            {
                rear = null;
            }
            length--;
            return result;
        }

    }
}
