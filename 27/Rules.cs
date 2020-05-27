using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameUnoWPF
{
    public class Rules
    {
        readonly Player player;
        public Rules(Player player)
        {
            this.player = player;
        }

        public void GetMarkOnCards(Deck deck, Card cardOnMap)
        {
            var listCardPlayer = player.CardList;
            for (int i=0;i<listCardPlayer.Count;i++)
            {
                if (cardOnMap.Color == listCardPlayer[i].Color || cardOnMap.Score == listCardPlayer[i].Score
                    || cardOnMap.Active == listCardPlayer[i].Active)
                    listCardPlayer[i].Mark = true;
                else listCardPlayer[i].Mark = false;
            }
        }

        internal void GetPropertiesSelectCard(string name, object turn)
        {
            throw new NotImplementedException();
        }
    }
}
