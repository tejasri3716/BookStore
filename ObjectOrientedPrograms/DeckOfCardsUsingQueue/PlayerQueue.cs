//--------------------------------------------------------------------------------------------------------------------
// <copyright file=PlayerQueue.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------

namespace ObjectOrientedPrograms.DeckOfCardsUsingQueue
{
    class PlayerQueue
    {
        private PlayerNode front;
        private PlayerNode rear;

        /// <summary>
        /// Gets or sets the front.
        /// </summary>
        /// <value>
        /// The front.
        /// </value>
        public PlayerNode Front
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
        public PlayerNode Rear
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
