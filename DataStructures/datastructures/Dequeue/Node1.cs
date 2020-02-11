using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class Node1
    {
        public Object info;
        public Node1 previous;
        public Node1 next;
        public Node1(Object info)
        {
            this.info = info;
            this.next = null;
        }
    }
}
