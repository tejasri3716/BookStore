//--------------------------------------------------------------------------------------------------------------------
// <copyright file=LinkedList.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------

namespace ObjectOrientedPrograms.CommercialDataProcessing
{
    /// <summary>
    /// Linked List class used to declare fields in Linked List
    /// </summary>
    public class LinkedList
    {
        private CompanyShares info;
        private LinkedList link;
        /// <summary>
        /// Gets or sets the information.
        /// </summary>
        /// <value>
        /// The information.
        /// </value>
        public CompanyShares Info { get => info; set => info = value; }
        /// <summary>
        /// Gets or sets the link.
        /// </summary>
        /// <value>
        /// The link.
        /// </value>
        public LinkedList Link { get => link; set => link = value; }
    }
}
