using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms.CommercialDataProcessing
{
    class LinkedList
    {
        private CompanyShares info;
        private LinkedList link;
        /// <summary>
        /// Gets or sets the information.
        /// </summary>
        /// <value>
        /// The information.
        /// </value>
        internal CompanyShares Info { get => info; set => info = value; }
        /// <summary>
        /// Gets or sets the link.
        /// </summary>
        /// <value>
        /// The link.
        /// </value>
        internal LinkedList Link { get => link; set => link = value; }
    }
}
