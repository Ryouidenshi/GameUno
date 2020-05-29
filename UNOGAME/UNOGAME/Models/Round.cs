using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNOGAME.ViewModels;

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
        public BoardInfo BoardInfo;
        public Round(List<Player> players, int current)
        {
            RoundDeck = new Deck();
            PlayersList = players;
            currentPlayer = current;
        }
        public Tuple<Player, int> Run()
        {
            BoardInfo = new BoardInfo(PlayersList, PlayersList[0].CardList);
            Info.boardInfo = BoardInfo;
            GiveOutCardsToPlayers();
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
                    BoardInfo.Update(PlayersList, PlayersList[0].CardList);
                }
            }
        }
        void NextPlayer()// переделать с учетом пропуска хода и сменой сторон
        {
            if (currentPlayer == 4)
                currentPlayer = 0;
            else
                currentPlayer++;
        }
    }
}
