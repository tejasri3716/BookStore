using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class DeQueue1<T>
    {
        Node1 front;
        Node1 rear;
        int length = 0;
        public void AddFront(T info)
        {
            Node1 node = new Node1(info);
            if (IsEmpty())
            {
                rear = node;
                length++;
            }
            else
            {
                front.previous = node;
                length++;
            }
            node.next = front;
            front = node;
        }
        public T DeleteFront()
        {
            T ele = (T)front.info;
            if (front.next == null)
            {
                rear = null;
            }
            else
            {
                front.next.previous = null;
                length--;
            }
            front = front.next;
            return ele;
        }
        public void AddRear(T info)
        {
            Node1 newNode = new Node1(info);
            if (IsEmpty())
            {
                front = newNode;
                length++;
            }
            else
            {
                rear.next = newNode;
                newNode.previous = rear;
                length++;
            }
            rear = newNode;
        }
        public T DeleteRear()
        {
            T element = (T)rear.info;
            if (front.next == null)
            {
                front = null;
                length--;
            }
            else
            {
                rear.previous.next = null;
            }
            rear = rear.previous;
            length--;
            return element;
        }
        public Boolean IsEmpty()
        {
            if (length == 0)
                return true;
            return false;
        }
        public void PrintDeQueue()
        {
            Node1 n = front;
            if (front == null)
            {
                Console.WriteLine("Dequeue is empty");
            }
            else
            {
                while (n != null)
                {
                    Console.WriteLine(n.info);
                    n = n.next;
                }
            }
        }
        public int Size()
        {
            return length;
        }
        public static void DequeueTtest()
        {
            DeQueue1<string> deQueue = new DeQueue1<string>();
            Console.WriteLine("enter number of elements");
            int num = Utility.readInt();
            for (int i = 0; i < num; i++)
            {
                deQueue.AddFront(Utility.readString());
            }
            Console.WriteLine("enter number of elements");
            int na = Utility.readInt();
            for (int i = 0; i < na; i++)
            {
                deQueue.AddRear(Utility.readString());
            }
            Console.WriteLine(deQueue.DeleteFront());
           Console.WriteLine(deQueue.DeleteRear());
             Console.WriteLine(deQueue.Size());
            deQueue.PrintDeQueue();
        }
    }
}
