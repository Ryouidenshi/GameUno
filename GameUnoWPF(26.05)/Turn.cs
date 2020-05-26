using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameUnoWPF
{
    public class Turn
    {
        private bool changeDirection;
        private bool take2cards;
        private bool skipMove;
        public bool ChangeDirection //пусть 0 - по часовой, 1  - против часовой (изначально ноль)
        {
            get { return changeDirection; }
            set { changeDirection = value; }
        }
        public bool Take2Cards
        {
            get { return take2cards; }
            set { take2cards = value; }
        }
        public bool SkipMove
        {
            get { return skipMove; }
            set { skipMove = value; }
        }
    }
}
