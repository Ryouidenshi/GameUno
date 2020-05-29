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

    public enum SkipMove
    {
        Skip,
        NotSkip
    }
    public class Round
    {
        readonly Direction direction;
        readonly SkipMove skipMove;
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
            if (direction == Direction.Сlockwise && skipMove == SkipMove.NotSkip && currentPlayer == 3)
                currentPlayer = 0;
            else if (direction == Direction.СounterСlockwise && skipMove == SkipMove.NotSkip && currentPlayer == 0)
                currentPlayer = 3;
            else if (direction == Direction.СounterСlockwise && skipMove == SkipMove.Skip && currentPlayer == 0)
                currentPlayer = 2;
            else if (direction == Direction.СounterСlockwise && skipMove == SkipMove.Skip && currentPlayer == 1)
                currentPlayer = 3;
            else if (direction == Direction.Сlockwise && skipMove == SkipMove.NotSkip)
                currentPlayer++;
            else if (direction == Direction.Сlockwise && skipMove == SkipMove.Skip)
                currentPlayer += 2;
            else if (direction == Direction.СounterСlockwise && skipMove == SkipMove.NotSkip)
                currentPlayer--;
            else if (direction == Direction.СounterСlockwise && skipMove == SkipMove.Skip)
                currentPlayer -= 2;
        }
    }
}
