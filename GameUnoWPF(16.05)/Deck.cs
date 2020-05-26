using System;
using System.Collections.Generic;
using System.Text;

<<<<<<< HEAD
namespace GameUnoWPF
=======
namespace GameUno
>>>>>>> 914e06f... GameUNO(16.05)
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

        public int Count
        {
            get { return deck.Count; }
        }
    }
}
