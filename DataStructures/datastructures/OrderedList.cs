using System;

namespace DataStructures
{
    public class OrderedList<T>
    {
        Node head;
        public void AddList(int data)
        {
            Node n = head;
            Node node = new Node(data);
            if (head == null || (int)n.info > (int)node.info)
            {
                node.link = head;
                head = node;
            }
            else
            {
                while (n.link != null && (int)n.link.info < (int)node.info)
                {
                    n = n.link;
                }
                node.link = n.link;
                n.link = node;
            }
        }
        public int Size()
        {
            Node node = head;
            int ind = 1;
            while (node.link != null)
            {
                node = node.link;
                ind++;
            }
            return ind;
        }
        public void PrintList()
        {
            Node node = head;

            while (node != null)
            {
                Console.WriteLine(node.info);
                node = node.link;
            }
            node = null;
        }
        internal int Remove(T data)
        {
            Node node = head.link;
            Node prev = null;
            if (head.info.Equals(data))
            {
                head = head.link;
                return (int)head.info;
            }
            else
            {
                while (!node.info.Equals(data))
                {
                    prev = node;
                    node = node.link;
                }
                int ret = (int)node.info;
                node = node.link;
                prev.link = node;

                return ret;
            }
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
        public Boolean IsEmpty()
        {
            Node n = head;
            if (n != null)
            {
                return true;
            }
            return false;
        }
        public Boolean Search(T info)
        {
            Node node = head;
            if (head.info.Equals(info))
            {
                return true;
            }
            else
            {
                while (!node.link.info.Equals(info))
                {
                    node = node.link;
                    return false;
                }
                return true;
            }
        }
    }
}
