using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class Node
    {
        public Object info;
        public Node link;
        public Node(Object info)
        {
            this.info = info;
            this.link = null;
        }
    }
}
