using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNOGAME.Models
{
    public class DeckCreation
    {
        public static Stack<Card> CreateDeck()
        {
            var cardList = GetCardsList();
            var deck = new Stack<Card>();
            var random = new Random();
            for (int i = 0; i < 100; i++)
            {
                var cardPosition = random.Next(cardList.Count);
                deck.Push(cardList[cardPosition]);
                cardList.RemoveAt(cardPosition);
            }
            return deck;
        }

        public static List<Card> GetCardsList()
        {
            List<Card> cards = new List<Card>();
            GetDigitalAndActiveCards(cards);
            return cards;
        }

        static void GetDigitalAndActiveCards(List<Card> cards)
        {
            AllColor((CardInscription)0, 1, cards);
            for (int i = 1; i <= 12; i++)
                AllColor((CardInscription)i, 2, cards);
        }

        static void AllColor(CardInscription active, int quantity, List<Card> cards)// all but not black :(
        {
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < quantity; j++)
                    cards.Add(new Card((ColorEnum)i /*+"_"*/+ active.ToString(), (ColorEnum)i, active, false));
        }
    }
}
