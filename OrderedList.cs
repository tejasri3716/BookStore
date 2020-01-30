using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class OrderedList
    {
        Node head;
        public void AddList(int info)
        {
            Node n = head;
            Node node = new Node(info);
            if (head == null || (int)n.info < (int)node.info)
            {
                n.link = head;
                head = node;
            }
            else
            {
                while (n.link != null && (int)n.link.info > (int)node.info)
                {
                    n = n.link;
                }
                node.link = n.link;
                n.link = node;
            }
        }
        public int Size()
        {
            Node n = head;
            int index = 1;
            while (n.link != null)
            {
                n = n.link;
                index++;
            }
            return index;
        }
        public void PrintList()
        {
            Node n = head;
            while (n != null)
            {
                Console.WriteLine(n.info);
                n = n.link;
            }
            n = null;
        }
        public int Remove(Object info)
        {
            Node node = head.link;
            Node prev = null;
            Node n = head;
            if (n.info.Equals(info))
            {
                n = n.link;
                return (int)head.info;
            }
            else
            {
                while (!n.link.info.Equals(info))
                {
                    prev = node;
                    node = node.link;
                }
                int res = (int)node.info;
                node = node.link;
                prev.link = node;

                return res;
            }
        }

            public Boolean Search (Object info)
            {
            Node n = head;
            if(n.info.Equals(info))
            {
                return true;
            }
            else
            {
                while(!n.link.info.Equals(info))
                {
                    n = n.link;
                    return false;
                }
                return true;
            }

            }

        }











    }

