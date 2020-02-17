using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms.CommercialDataProcessing
{
    public class Node
    {
        private String data;
        private Node link;

        public string Data
        {
            get
            {
                return this.data;
            }
            set
            {
                this.data = value;
            }
        }
        public Node Link
        {
            get
            {
                return this.link;
            }
            set
            {
                this.link = value;
            }
        }
    }
}
