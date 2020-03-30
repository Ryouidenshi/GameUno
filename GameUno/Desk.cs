using System;
using System.Collections.Generic;
using System.Text;

namespace GameUno
{
    public class Desk : MarshalByRefObject
    {
        private static Gamer gamer = new Gamer();
        public static Stack<Card> cardsOnDesk = new Stack<Card>();

        public List<Card> GetAllCardsOnDesk()
        {
            return cardsOnDesk;
        }

        public void AddCardOnDesk(Card card)
        {
            if (gamer.Remove(card))
                cardsOnDesk.Add(card);
        }

        public void RemoveCardOnDesk(Card card)
        {
            if (gamer.Add(card))
                cardsOnDesk.Remove(card);
        }
    }
}
//Это стол для игры, то есть куда ложить карты и тд, то есть тупо игровое поле
