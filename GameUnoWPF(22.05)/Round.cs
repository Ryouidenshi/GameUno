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
        int CurrentPlayer;
        public Deck RoundDeck { get; set; }
        public List<Player> PlayersList { get; set; }
        public Round(List<Player> players, int current)
        {
            RoundDeck = new Deck();
            PlayersList = players;
            CurrentPlayer = current;
        }
        public Tuple<Player, int> Run()
        {
            GiveOutCardsToPlayers();
            bool isSomebodyWin = false;
            Player winner = new Player("winner");
            return new Tuple<Player, int>(winner, 32);
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
        public void NextPlayer()
        {
            if (CurrentPlayer == 4)
                CurrentPlayer = 0;
            else
                CurrentPlayer++;
        }
    }
}
