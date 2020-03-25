using System;
using System.Collections.Generic;
using System.Text;

namespace GameUno
{
    public class Game : MarshalByRefObject
    {

        public Dictionary<string, bool> Cards { get; set; }

        public Game(Cards cards)
        {
            Cards = new Dictionary<string, bool>();
        }

    }
}
