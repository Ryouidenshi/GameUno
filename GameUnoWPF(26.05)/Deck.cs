using System;
using System.Collections.Generic;
using System.Text;

namespace GameUnoWPF
{
    public class Deck
    {
        readonly Stack<Card> deck;

        public Deck()
        {
            deck = DeckCreation.CreateDeck();
        }

        public Card Draw()
        {
            return deck.Pop();
        }

        public Card CardOnDesk()
        {
            return deck.Peek();
        }

        public int Count
        {
            get { return deck.Count; }
        }
    }
}
