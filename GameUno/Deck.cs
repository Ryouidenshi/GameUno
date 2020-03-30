using System;
using System.Collections.Generic;
using System.Text;

namespace GameUno
{
    class Deck
    {
        readonly Stack<Card> deck;

        public Deck()
        {
            deck = DeckCreation.CreateDeck();
        }

        public Card Drow()
        {
            return deck.Pop();
        }

        public int Count
        {
            get { return deck.Count; }
        }
    }
}
