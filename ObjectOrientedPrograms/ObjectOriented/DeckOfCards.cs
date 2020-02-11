using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms
{
    class DeckOfCards
    {
        public void DistributeCards()
        {
            String[] Suits = { "Club", "Diamond", "Heart", "Spade" };
            String[] Rank = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
            String[,] Cards = new String[4, 13];
            String[,] Players = new String[4, 13];
            Utility.CardArray(Suits, Cards, Rank);


        }
    }
}
