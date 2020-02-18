//--------------------------------------------------------------------------------------------------------------------
// <copyright file="UtilityQueue.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace ObjectOrientedPrograms.DeckOfCardsUsingQueue
{
    using System;

    /// <summary>
    /// Utility Queue for shuffling and distributing cards
    /// </summary>
    class UtilityQueue
    {
        /// <summary>
        /// Generates the random.
        /// </summary>
        /// <param name="num">The maximum.</param>
        /// <returns></returns>
        public static int GenerateRandom(int num)
        {
            Random random = new Random();
            return random.Next(num);
        }
        /// <summary>
        /// Arrays the of cards.
        /// </summary>
        /// <param name="CardArray">The card array.</param>
        /// <param name="Suits">The suits.</param>
        /// <param name="Ranks">The ranks.</param>
        public static void ArrayOfCards(string[,] cardArray, string[] suits, int[] ranks)
        {
            for (int i = 0; i < cardArray.GetLength(0); i++)
            {
                for (int j = 0; j < cardArray.GetLength(1); j++)
                {
                    if (j < 8)
                    {
                        cardArray[i, j] = suits[i] + "-" + ranks[j];
                    }
                    else if (j == 8)
                    {
                        cardArray[i, j] = suits[i] + "-" + "Jack";
                    }
                    else if (j == 9)
                    {
                        cardArray[i, j] = suits[i] + "-" + "Queen";
                    }
                    else if (j == 10)
                    {
                        cardArray[i, j] = suits[i] + "-" + "King";
                    }
                    else if (j == 11)
                    {
                        cardArray[i, j] = suits[i] + "-" + "Ace";
                    }
                }
            }
        }
        /// <summary>
        /// Shuffles the specified array.
        /// </summary>
        /// <param name="Array">The array.</param>
        public static void Shuffle(string[,] array)
        {
            int rowIndex1 = 0;
            int columnIndex1 = 0;
            int rowIndex2 = 0;
            int columnIndex2 = 0;

            for (int i = 0; i < 52; i++)
            {
                rowIndex1 = GenerateRandom(4);
                columnIndex1 = GenerateRandom(13);
                rowIndex2 = GenerateRandom(4);
                columnIndex2 = GenerateRandom(13);
                ////call the swap method to swap the elements of array
                Swap(array, rowIndex1, columnIndex1, rowIndex2, columnIndex2);
            }
        }
        /// <summary>
        /// Swaps the specified array.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <param name="rowIndex1">The row index1.</param>
        /// <param name="columnIndex1">The column index1.</param>
        /// <param name="rowIndex2">The row index2.</param>
        /// <param name="columnIndex2">The column index2.</param>
        public static void Swap(string[,] array, int rowIndex1, int columnIndex1, int rowIndex2, int columnIndex2)
        {
            string temp = array[rowIndex1, columnIndex1];
            array[rowIndex1, columnIndex1] = array[rowIndex2, columnIndex2];
            array[rowIndex2, columnIndex2] = temp;
        }
        /// <summary>
        /// Display2s the d player array.
        /// </summary>
        /// <param name="PlayersArray">The players array.</param>
        public static void Display2DPlayerArray(string[,] playersArray)
        {
            for (int i = 0; i < playersArray.GetLength(0); i++)
            {
                for (int j = 0; j < playersArray.GetLength(1); j++)
                    Console.Write(playersArray[i, j]);
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Creates the q player.
        /// </summary>
        /// <returns></returns>
        public static PlayerQueue CreateQPlayer()
        {
            PlayerQueue queuePlayer = new PlayerQueue();
            queuePlayer.Front = null;
            queuePlayer.Rear = null;
            return queuePlayer;
        }
        /// <summary>
        /// Creates the Queue to store cards for players
        /// </summary>
        /// <returns></returns>
        public static CardsQueue CreateQCard()
        {
            CardsQueue queueCard = new CardsQueue();
            queueCard.Front = null;
            queueCard.Rear = null;
            return queueCard;
        }
        /// <summary>
        /// Adds the players in queue.
        /// </summary>
        /// <param name="queuePlayer">The queue player.</param>
        public static void AddPlayersInQueue(PlayerQueue queuePlayer)
        {
            for (int i = 0; i < 4; i++)
            {
                Player player = new Player();
                AddPlayers(queuePlayer, player);
            }
        }
        /// <summary>
        /// Adds the players.
        /// </summary>
        /// <param name="queuePlayer">The queue player.</param>
        /// <param name="playerObj">The player object.</param>
        public static void AddPlayers(PlayerQueue queuePlayer, Player playerObj)
        {
            PlayerNode playerNode = new PlayerNode();
            playerNode.Data = playerObj;

            if (queuePlayer.Rear == null)
                queuePlayer.Rear = playerNode;
            else
            {
                queuePlayer.Rear.Next = playerNode;
                queuePlayer.Rear = playerNode;
            }

            if (queuePlayer.Front == null)
                queuePlayer.Front = queuePlayer.Rear;
        }
        /// <summary>
        /// Distributes the cards.
        /// </summary>
        /// <param name="queuePlayer">The queue player.</param>
        /// <param name="Array">The array.</param>
        public static void DistributeCards(PlayerQueue queuePlayer, string[,] array)
        {
            PlayerNode tempPlayer = queuePlayer.Front;

            for (int i = 0; i < 13; i++)
            {
                ////select the player
                tempPlayer = queuePlayer.Front;
                for (int j = 0; j < 4; j++)
                {
                    ////create a new card to insert into the queue card of player
                    CardNode card = new CardNode();
                    ////assing the values (suit and rank) from array to card
                    card = InputCardData(card, array[j, i]);
                    ////insert the card to the specified player's queue
                    if (card != null)
                        AddCardsToQueueCard(tempPlayer.Data.queueCard, card);
                    ////go to next player
                    tempPlayer = tempPlayer.Next;
                }
            }
        }
        /// <summary>
        /// Inputs the card data.
        /// </summary>
        /// <param name="card">The card.</param>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        public static CardNode InputCardData(CardNode card, string input)
        {
            string[] splitArray = null;
            if (input != null)
                splitArray = input.Split("-");
            else
            {
                // Console.WriteLine("input is null");
                return null;
            }

            card.Suit = splitArray[0];
            int rank = 0;

            if (splitArray[1] == "Jack")
            {
                card.Rank = 11;
            }
            else if (splitArray[1] == "Queen")
            {
                card.Rank = 12;
            }
            else if (splitArray[1] == "King")
            {
                card.Rank = 13;
            }
            else if (splitArray[1] == "Ace")
            {
                card.Rank = 14;
            }
            else
            {
                rank = Convert.ToInt32(splitArray[1]);
                card.Rank = rank;
            }
            return card;
        }
        /// <summary>
        /// Adds the cards to queue card.
        /// </summary>
        /// <param name="queueCard">The queue card.</param>
        /// <param name="card">The card.</param>
        public static void AddCardsToQueueCard(CardsQueue queueCard, CardNode card)
        {
            CardNode temp = null;
            if (queueCard.Rear == null)
            {
                queueCard.Rear = card;
            }
            else
            {
                temp = queueCard.Rear;
                temp.Next = card;
                queueCard.Rear = card;
            }
            if (queueCard.Front == null)
            {
                queueCard.Front = queueCard.Rear;
            }
        }
        /// <summary>
        /// Prints the player.
        /// </summary>
        /// <param name="queuePlayer">The queue player.</param>
        public static void PrintQueuePlayer(PlayerQueue queuePlayer)
        {
            int count = 0;
            ////Console.WriteLine("inside printQueuePlayer method");
            CardNode tempPlayerCard = null;
            PlayerNode tempPlayer = queuePlayer.Front;
            while (tempPlayer != null)
            {
                Console.WriteLine("Player " + ++count);
                tempPlayerCard = tempPlayer.Data.queueCard.Front;
                while (tempPlayerCard != null)
                {
                    if (tempPlayerCard.Rank > 10)
                    {
                        if (tempPlayerCard.Rank == 11)
                        {
                            Console.Write(tempPlayerCard.Suit + "-" + "Jack  ");
                        }
                        else if (tempPlayerCard.Rank == 12)
                        {
                            Console.Write(tempPlayerCard.Suit + "-" + "Queen  ");
                        }
                        else if (tempPlayerCard.Rank == 13)
                        {
                            Console.Write(tempPlayerCard.Suit + "-" + "King  ");
                        }
                        else if (tempPlayerCard.Rank == 14)
                        {
                            Console.Write(tempPlayerCard.Suit + "-" + "Ace  ");
                        }
                    }
                    else
                    {
                        Console.Write(tempPlayerCard.Suit + "-" + tempPlayerCard.Rank + "  ");
                    }
                    tempPlayerCard = tempPlayerCard.Next;
                }
                Console.WriteLine();
                tempPlayer = tempPlayer.Next;
            }
        }
        /// <summary>
        /// Sorts the specified queue player.
        /// </summary>
        /// <param name="queuePlayer">The queue player.</param>
        public static void Sort(PlayerQueue queuePlayer)
        {
            PlayerNode temp = queuePlayer.Front;
            while (temp != null)
            {
                SortCardQueue(temp.Data.queueCard);
                temp = temp.Next;
            }
        }
        /// <summary>
        /// Sorts the card queue.
        /// </summary>
        /// <param name="queueCard">The queue card.</param>
        public static void SortCardQueue(CardsQueue queueCard)
        {
            CardNode first = queueCard.Front;
            CardNode second = null;
            string tempSuit = null;
            int tempRank = 0;

            while (first != null)
            {
                second = first.Next;
                while (second != null)
                {
                    if (first.Rank > second.Rank)
                    {
                        tempSuit = first.Suit;
                        tempRank = first.Rank;
                        first.Suit = second.Suit;
                        first.Rank = second.Rank;
                        second.Suit = tempSuit;
                        second.Rank = tempRank;
                    }
                    second = second.Next;
                }
                first = first.Next;
            }
        }
    }
}