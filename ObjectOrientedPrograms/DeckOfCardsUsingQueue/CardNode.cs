// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CardNode.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace ObjectOrientedPrograms.DeckOfCardsUsingQueue
{
    using System;

    /// <summary>
    /// class Node for cards
    /// </summary>
    public class CardNode
    {
        /// <summary>
        /// The suit
        /// </summary>
        private String suit;
        /// <summary>
        /// The rank
        /// </summary>
        private int rank;
        /// <summary>
        /// The next
        /// </summary>
        private CardNode next;

        /// <summary>
        /// Gets or sets the suit.
        /// </summary>
        /// <value>
        /// The suit.
        /// </value>
        public string Suit
        {
            get
            {
                return this.suit;
            }
            set
            {
                this.suit = value;
            }
        }
        /// <summary>
        /// Gets or sets the rank.
        /// </summary>
        /// <value>
        /// The rank.
        /// </value>
        public int Rank
        {
            get
            {
                return this.rank;
            }
            set
            {
                this.rank = value;
            }
        }
        /// <summary>
        /// Gets or sets the next.
        /// </summary>
        /// <value>
        /// The next.
        /// </value>
        public CardNode Next
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
