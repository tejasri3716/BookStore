// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeckOfCards.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace ObjectOrientedPrograms
{
    using System;

    /// <summary>
    /// Deck Of Cards class is used for shuffling and distributing cards to players
    /// </summary>
    class DeckOfCards
    {
        /// <summary>
        /// Distributes the cards.
        /// </summary>
        public void DistributeCards()
        {
            String[] Suits = { "Club", "Diamond", "Heart", "Spade" };
            String[] Rank = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
            String[,] Cards = new String[4, 13];
            String[,] Players = new String[4, 13];
            Utility.CardArray(Suits, Cards, Rank);

            Utility.ShufflingCards(Cards);

            ////Distributes 9 - 9 cards to each of 4 player
            Utility.DistributingCards(Cards, Players);

            //// prints the cards with each players
            Utility.PrintString2DArray(Players);
        }
    }
}
