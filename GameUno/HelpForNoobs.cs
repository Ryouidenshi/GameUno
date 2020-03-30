using System;
using System.Collections.Generic;
using System.Text;

namespace GameUno
{
    public class HelpForNoobs : MarshalByRefObject
    {
        private static Desk desk = new Desk();
        private static Gamer gamer = new Gamer();
        public void ToPossibility()
        {
            var cardsOnDesk = desk.cardsOndDesk;
            var lastCard = cardsOnDesk.Pop();
            var color = lastCard.Color;
            var picture = lastCard.Picture;
            foreach(var card in gamer.Alignment)
            {
                if (card.Color == color || card.Picture == picture)
                    card.mark = true;
            }
        }
    }
}
