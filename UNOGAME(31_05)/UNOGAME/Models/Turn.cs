using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNOGAME.Models
{
    public class Turn
    {
        public bool ChangeDirection;
        public bool Take2cards;
        public bool SkipMove;

        public Turn(bool direction, bool take, bool skip)
        {
            ChangeDirection = direction;
            Take2cards = take;
            SkipMove = skip;
        }
        public static Turn MakeTurn(Card topCard, Card card)
        {
            if (card.Inscription == CardInscription.TakeTwoCards)
            {
                if (topCard.Inscription == CardInscription.TakeTwoCards)
                    return new Turn(false, false, false);
            }
            else if (card.Inscription == CardInscription.ChangeDirection)
                if (topCard.Inscription == CardInscription.TakeTwoCards)
                    return new Turn(true, true, false);
                else return new Turn(true, false, false);
            else if (card.Inscription == CardInscription.Skip)
                if (topCard.Inscription == CardInscription.TakeTwoCards)
                    return new Turn(false, true, true);
                else return new Turn(false, false, true);
            else if (topCard.Inscription == CardInscription.TakeTwoCards)
                return new Turn(false, true, false);
            return new Turn(false, false, false);
        }
    }
}
