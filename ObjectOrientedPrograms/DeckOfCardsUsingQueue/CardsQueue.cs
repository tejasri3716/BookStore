using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms.DeckOfCardsUsingQueue
{
    /// <summary>
    /// class for declaring two pointers
    /// </summary>
    public class CardsQueue
    {
        private CardNode front;
        private CardNode rear;

        /// <summary>
        /// Gets or sets the front.
        /// </summary>
        /// <value>
        /// The front.
        /// </value>
        public CardNode Front
        {
            get
            {
                return this.front;
            }
            set
            {
                this.front = value;
            }
        }
        /// <summary>
        /// Gets or sets the rear.
        /// </summary>
        /// <value>
        /// The rear.
        /// </value>
        public CardNode Rear
        {
            get
            {
                return this.rear;
            }
            set
            {
                this.rear = value;
            }
        }
    }
}
