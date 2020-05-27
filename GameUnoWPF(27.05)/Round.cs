using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace GameUnoWPF
{
    enum Directions
    {
        Сlockwise,
        СounterСlockwise
    }
    public class Round
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
            var window = new Model(this);
            
            GiveOutCardsToPlayers(window);
            bool isSomebodyWin = false;
            while (!isSomebodyWin)
            {

            }
            Player winner = new Player("winner");
            return new Tuple<Player, int>(winner, 32);
        }

        void GiveOutCardsToPlayers(Model model)
        {
            for (int i = 0; i < 7; i++)
            {
                foreach (var player in PlayersList)
                {
                    player.Take(RoundDeck.Draw());
                }
                model.Update(this);
            }
                
        }
        void NextPlayer()
        {

            if (CurrentPlayer == 4)
                CurrentPlayer = 0;
            else
                CurrentPlayer++;
        }
    }
}
