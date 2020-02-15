using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms
{
    public class StackNode
    {
        private String status;
        private StackNode next;

        public string Status
        {
            get
            {
                return this.status;
            }
            set
            {
                this.status = value;
            }
        }
        public StackNode Next
        {
            get
            {
                return this.next;
            }
            set
            {
                this.next = value;
            }
        }
    }
}
