using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameUnoWPF
{
    class Bot : Player
    {
        public Bot(string name) : base(name)
        {
            Name = name;
        }

        public void MakeTurn(Card topCard)
        {
            for (int i = 0; i < CardList.Count; i++)
                if (CardList[i].Color == topCard.Color || CardList[i].Active == topCard.Active);

        }
    }
}
