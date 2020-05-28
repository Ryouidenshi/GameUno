using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNOGAME.Models
{
    public class Bot : Player
    {
        public Bot(string name) : base(name)
        {
            Name = name;
        }

        public void MakeTurn(Card topCard)
        {

        }
    }
}
