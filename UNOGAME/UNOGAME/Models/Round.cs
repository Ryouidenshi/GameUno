using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNOGAME.Models.BoardInfoSpace;

namespace UNOGAME.Models
{
    public enum Direction
    {
        Сlockwise,
        СounterСlockwise
    }
    public class Round
    {
        Direction direction;
        int currentPlayer;
        public Deck RoundDeck { get; set; }
        public List<Player> PlayersList { get; set; }
        public Round(List<Player> players, int current)
        {
            RoundDeck = new Deck();
            PlayersList = players;
            currentPlayer = current;
        }
        public Tuple<Player, int> Run()
        {

            GiveOutCardsToPlayers();
            BoardInfo boardInfo;
            bool isSomebodyWin = false;
            while (!isSomebodyWin)
            {

            }
            Player winner = new Player("winner");
            return new Tuple<Player, int>(winner, 32);
        }

        void GiveOutCardsToPlayers()
        {
            for (int i = 0; i < 7; i++)
            {
                foreach (var player in PlayersList)
                {
                    player.Take(RoundDeck.Draw());
                }
            }

        }
        void NextPlayer()
        {
            if (currentPlayer == 4)
                currentPlayer = 0;
            else
                currentPlayer++;
        }
    }
}
