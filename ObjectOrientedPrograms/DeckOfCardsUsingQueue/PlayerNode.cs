//--------------------------------------------------------------------------------------------------------------------
// <copyright file=PlayerNode.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------

namespace ObjectOrientedPrograms.DeckOfCardsUsingQueue
{
    class PlayerNode
    {
        /// <summary>
        /// The player data
        /// </summary>
        private Player data;
        /// <summary>
        /// The next of type PlayerNode
        /// </summary>
        private PlayerNode next;

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public Player Data
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
        /// Gets or sets the next.
        /// </summary>
        /// <value>
        /// The next.
        /// </value>
        public PlayerNode Next
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
