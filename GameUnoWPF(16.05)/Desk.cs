using System;
using System.Collections.Generic;
using System.Text;

namespace GameUnoWPF
{
    public class Desk : MarshalByRefObject
    {
        private static Game game = new Game();
        private static string player;
        private static Gamer gamer = new Gamer(game, player);
        public static List<Card> cardsOnDesk = new List<Card>();
        public static bool mark = false;

        public List<Card> GetAllCardsOnDesk()
        {
            return cardsOnDesk;
        }

        public void AddCardOnDesk(Card card)
        {
            gamer.RemoveCard(card, mark);
            if (mark==true)
                cardsOnDesk.Add(card);
            mark = false;
        }

        public void RemoveCardOnDesk(Card card)
        {
            gamer.AddCard(card, mark);
            if (mark==true)
                cardsOnDesk.Remove(card);
            mark = false;
        }

        public static Card ReturnLastcard()
        {
            return cardsOnDesk[cardsOnDesk.Count - 1];
        }
    }
}
//Это стол для игры, то есть куда ложить карты и тд, то есть тупо игровое поле
