using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameUnoWPF
{
    class Round
    {
        public Deck RoundDeck { get; set; }
        public List<Player> PlayersList { get; set; }
        public Round(List<Player> players)
        {
            RoundDeck = new Deck();
            PlayersList = players;
        }
        public void Run()
        {
            GiveOutCardsToPlayers();
            bool isSomebodyWin = false;
            Player winner = new Player("winner");
            
            
        }

        void GiveOutCardsToPlayers()
        {
            for (int i = 0; i < 7; i++)
                foreach (var player in PlayersList)
                {
                    player.Take(RoundDeck.Draw());
                    Thread.Sleep(100);
                    //передача инфы в модел
                }

        }
    }
}
