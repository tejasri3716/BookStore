//--------------------------------------------------------------------------------------------------------------------
// <copyright file="Node.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace ObjectOrientedPrograms.CommercialDataProcessing
{
    using System;

    /// <summary>
    /// Node class used to get and set data and link
    /// </summary>
    public class Node
    {
        private String data;
        private Node link;

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
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
        /// <summary>
        /// Gets or sets the link.
        /// </summary>
        /// <value>
        /// The link.
        /// </value>
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
