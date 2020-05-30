using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNOGAME.Models
{
    public class Player
    {
        public List<Card> CardList = new List<Card>();
        public string Name;
        public Player(string name)
        {
            Name = name;
        }

        public void Take(Card card)
        {
            CardList.Add(card);
        }

        public void Clear()
        {
            CardList.Clear();
        }
    }
}
