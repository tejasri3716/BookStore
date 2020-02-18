// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeckOfCardsUsingQ.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace ObjectOrientedPrograms.DeckOfCardsUsingQueue
{
    using System;
 
    /// <summary>
    /// class for Deck Of Cards Using Queue
    /// </summary>
    class DeckOfCardsUsingQ
    {
        public static void DistributeCards()
        {
            String[] Suits = { "Club", "Diamond", "Heart", "Spade" };
            int[] Ranks = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            String[,] Cards = new String[4, 13];
            UtilityQueue.ArrayOfCards(Cards, Suits, Ranks);
            UtilityQueue.Shuffle(Cards);
            PlayerQueue playerQueue = UtilityQueue.CreateQPlayer();
            UtilityQueue.AddPlayersInQueue(playerQueue);
            UtilityQueue.DistributeCards(playerQueue, Cards);
            UtilityQueue.Sort(playerQueue);
            Console.WriteLine("After Sorting :");
            UtilityQueue.PrintQueuePlayer(playerQueue);
        }
    }
}
