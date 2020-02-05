using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class HashMap1
    {
        Node[] array = new Node[11];
         int rem=0;
        public void Hashing(int info)
        {
            Node node = new Node(info);
            rem = info % 11;
            Console.WriteLine("remainder is :" + rem);
            Node n = array[rem];
            if (array[rem] == null )
            {
                array[rem] = node;
            }
            else
            {
                while (n.link != null )
                {
                    n = n.link;
                }
                n.link = node;
            }
        }
         public void PrintList()
        {
            Node n = array[rem];
            while (n  != null)
            {
                Console.WriteLine(n.info);
                n = n.link;
            }
        }
    }
}
