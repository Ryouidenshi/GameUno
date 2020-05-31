using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNOGAME.Models
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
            return deck.Count!=0 ? deck.Pop() : null ;
        }
        public int Count
        {
            get { return deck.Count; }
        }

    }
}
