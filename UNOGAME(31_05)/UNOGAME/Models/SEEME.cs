using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNOGAME.Models
{
    class SEEME //я чот не нашёл куда и где раздача карт поэтому напишу тут краткий алгоритм
    {
        readonly Deck deck;
        public void GetCards(Dictionary<int, bool> markCards, int currentPlayer, List<Card> listCardPlayer)
        {
            if (markCards.Count() == 0 && currentPlayer == 0)
                listCardPlayer.Add(deck.Draw());
        }
    }
}
