using System;
using System.Collections.Generic;
using System.Text;

namespace GameUno
{
    public class DeckCreation
    {
        public static Stack<Card> CreateDeck()
        {
            var cardList = GetCardsList();
            var deck = new Stack<Card>();
            var random = new Random();
            for (int i = 0; i < 108; i++)
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
            GetBlackCards(cards);
            return cards;
        }
        static void GetBlackCards(List<Card> cards)
        {
            for (int i = 13; i <= 14; i++)
                for (int j = 0; j < 4; j++)
                    cards.Add(new Card("Black"+ (CardInfo)i, (ColorEnum)5, (CardInfo)i, false));
        }
        static void GetDigitalAndActiveCards(List<Card> cards)
        {
            AllColor((CardInfo)0, 1, cards);
            for (int i = 1; i <= 12; i++)
                AllColor((CardInfo)i, 2, cards);
        }
        static void AllColor(CardInfo active, int quantity, List<Card> cards)// all but not black :(
        {
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < quantity; j++)
                    cards.Add(new Card((ColorEnum)i+active.ToString(), (ColorEnum)i, active,false));
        }
    }
}
