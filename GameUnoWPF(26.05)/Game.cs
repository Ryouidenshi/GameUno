﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameUnoWPF
{
    public class Game : MarshalByRefObject
    {
        int CurrentPlayer = 0;
        public List<Player> PlayersList { get; set; }

        readonly Dictionary<Player, int> PlayersScore = new Dictionary<Player, int>();
        public Game(List<Player> players)
        {
            PlayersList = players;
        }
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

        public void AddBots(int count)
        {
            for (int i = 1; i <= count; i++)
                PlayersList.Add(new Bot(i.ToString()));
        }

        public void NextPlayerStart()
        {
            if (CurrentPlayer == 3)
                CurrentPlayer = 0;
            else
                CurrentPlayer++;
        }
    }
}
