using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class Node
    {
        public Object info;
        public Node link;
        public Node(Object i)
        {
            this.info = i;
            this.link = null;
        }
    }
}
