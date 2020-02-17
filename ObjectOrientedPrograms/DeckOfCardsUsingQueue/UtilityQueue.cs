using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms.DeckOfCardsUsingQueue
{
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
        public static void ArrayOfCards(string[,] CardArray, string[] Suits, int[] Ranks)
        {
            for (int i = 0; i < CardArray.GetLength(0); i++)
            {
                for (int j = 0; j < CardArray.GetLength(1); j++)
                {
                    if (j < 8)
                    {
                        CardArray[i, j] = Suits[i] + "-" + Ranks[j];
                    }
                    else if (j == 8)
                    {
                        CardArray[i, j] = Suits[i] + "-" + "Jack";
                    }
                    else if (j == 9)
                    {
                        CardArray[i, j] = Suits[i] + "-" + "Queen";
                    }
                    else if (j == 10)
                    {
                        CardArray[i, j] = Suits[i] + "-" + "King";
                    }
                    else if (j == 11)
                    {
                        CardArray[i, j] = Suits[i] + "-" + "Ace";
                    }
                }
            }
        }

        public static void Shuffle(string[,] Array)
        {
            int rowIndex1 = 0;
            int ColumnIndex1 = 0;
            int rowIndex2 = 0;
            int ColumnIndex2 = 0;

            for (int i = 0; i < 52; i++)
            {
                rowIndex1 = GenerateRandom(4);
                ColumnIndex1 = GenerateRandom(13);
                rowIndex2 = GenerateRandom(4);
                ColumnIndex2 = GenerateRandom(13);
                ////call the swap method to swap the elements of array
                Swap(Array, rowIndex1, ColumnIndex1, rowIndex2, ColumnIndex2);
            }
        }

        public static void Swap(string[,] Array, int rowIndex1, int columnIndex1, int rowIndex2, int columnIndex2)
        {
            string temp = Array[rowIndex1, columnIndex1];
            Array[rowIndex1, columnIndex1] = Array[rowIndex2, columnIndex2];
            Array[rowIndex2, columnIndex2] = temp;
        }

        public static void Display2DPlayerArray(string[,] PlayersArray)
        {
            for (int i = 0; i < PlayersArray.GetLength(0); i++)
            {
                for (int j = 0; j < PlayersArray.GetLength(1); j++)
                    Console.Write(PlayersArray[i, j]);
                Console.WriteLine();
            }
        }

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
        public static void AddPlayersInQueue(PlayerQueue queuePlayer)
        {
            for (int i = 0; i < 4; i++)
            {
                Player player = new Player();
                AddPlayers(queuePlayer, player);
            }
        }
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

        public static void DistributeCards(PlayerQueue queuePlayer, string[,] Array)
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
                    card = InputCardData(card, Array[j, i]);
                    ////insert the card to the specified player's queue
                    if (card != null)
                        AddCardsToQueueCard(tempPlayer.Data.queueCard, card);
                    ////go to next player
                    tempPlayer = tempPlayer.Next;
                }
            }
        }
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

        public static void Sort(PlayerQueue queuePlayer)
        {
            PlayerNode temp = queuePlayer.Front;
            while (temp != null)
            {
                SortCardQueue(temp.Data.queueCard);
                temp = temp.Next;
            }
        }
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
