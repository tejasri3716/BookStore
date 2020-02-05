using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace DataStructures
{
    class UnOrderedList<T>
    {
        Node head;

        public void Add(T info)
        {
            Node nextNode = head;

            Node node = new Node(info);
            if (head == null)
            {
                head = node;
            }
            else
            {
                while (nextNode.link != null)
                {
                    nextNode = nextNode.link;
                }

                nextNode.link = node;

            }
        }
        public void PrintList()
        {
            Node n = head;
            while (n != null)
            {
                Console.WriteLine(n.info);
                n = n.link;
            }

        }
        public int Size()
        {
            Node n = head;
            int count = 1;
            while (n.link != null)
            {
                count++;
                n = n.link;

            }
            return count;
        }
        public int Index(T index)
        {
            int position = 1;
            Node n = head;
            if (n != null && n.info.Equals(index))
            {
                n = n.link;
                return position;
            }
            else
            {
                while (!n.info.Equals(index) && n.link != null)
                {
                    n = n.link;
                    position++;
                }
                n = n.link;
            }
            return position;
        }
        public Boolean Search(T data)
        {
            Node n = head;
            while (n != null)
            {
                if (n.info.Equals(data))
                {
                    return true;
                }
                n = n.link;
            }
            return false;
        }
        public Boolean IsEmpty()
        {
            Node n = head;
            if (n != null)
            {
                return true;
            }
            return false;
        }
        public void Append(T info)
        {
            Node nextNode = head;
            Node node = new Node(info);
            if (head == null)
            {
                head = node;
            }
            else
            {
                while (nextNode.link != null)
                {
                    /*String s=Convert.ToString(nextNode.info);
                    System.IO.File.WriteAllText(@"C:\Users\BridgeLabz\source\repos\Input.txt", s);*/
                    nextNode = nextNode.link;
                }

                nextNode.link = node;
                /*String s = Convert.ToString(nextNode.info);
                System.IO.File.WriteAllText(@"C:\Users\BridgeLabz\source\repos\Input.txt", s);*/

            }
        }
        public void Remove(T remove)
        {
            Node n = head;
            Node prev = null;
            if (n.info.Equals(remove))
            {
                head = head.link;
            }
            else
            {
                while (!n.info.Equals(remove))
                {
                    prev = n;
                    n = n.link;
                }
                prev.link = n.link;
                n = n.link;
            }
        }
        public void Insert(int position, T info)
        {
            int pos = 1;
            Node n = head;
            Node node = new Node(info);
            if (position == 1)
            {
                node.link = head;
                head = node;
            }
            else
            {
                while (pos != position)
                {
                    n = n.link;
                    pos = pos + 1;
                }
                node.link = n.link;
                n.link = node;
            }
        }
        public T Pop(int position)
        {
            int pos = 1;
            Node n = head;
            Node prev = null;
            while (n != null && pos < position)
            {
                prev = n;
                n = n.link;
                pos++;
            }
            prev.link = n.link;
            return (T)n.info;
        }
        public T Pop()
        {
            Node n = head;
            Node prev = null;
            while (n.link != null)
            {
                prev = n;
                n = n.link;
            }
            T data = (T)n.info;
            prev.link = null;
            return (T)data;
        }

    }
}
