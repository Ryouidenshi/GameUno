using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNOGAME.Models
{
    public class Game
    {
        int CurrentPlayer = 0;
        public List<Player> PlayersList { get; set; }

        readonly Dictionary<Player, int> PlayersScore = new Dictionary<Player, int>();
        public Game(List<Player> players)
        {
        PlayersList = players;
        }
        [STAThread]
        public Player Run()
        {
            bool isSomebodyWin = false;
            Player winner = new Player("winner");
            if (PlayersList.Count < 4)
            AddBots(4 - PlayersList.Count);
            while (!isSomebodyWin)
            {
                var round = new Round(PlayersList, CurrentPlayer);
                var roundWinner = round.Run();
                if(PlayersScore.ContainsKey(roundWinner.Item1))
                    PlayersScore[roundWinner.Item1] += roundWinner.Item2;
                else
                    PlayersScore[roundWinner.Item1] = roundWinner.Item2;
                foreach (var pair in PlayersScore)
                if (pair.Value > 500)
                {
                    winner = pair.Key;
                    isSomebodyWin = true;
                }
                NextPlayerStart();
            }
            return winner;
        }

        void AddBots(int count)
        {
            Bot.CreateBotNames();
            for (int i = 1; i <= count; i++)
                PlayersList.Add(new Bot(""));
        }

        void NextPlayerStart()
        {
            CurrentPlayer++;
            if (CurrentPlayer == 4)
            CurrentPlayer = 0;
        }
    }
}
