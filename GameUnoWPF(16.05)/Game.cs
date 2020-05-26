using System;
using System.Collections.Generic;
using System.Text;

<<<<<<< HEAD
namespace GameUnoWPF
{
    public class Game : MarshalByRefObject
    {
        public List<Player> PlayersList { get; set; }
        Dictionary<Player, int> PlayersScore = new Dictionary<Player, int>();
        public Game(List<Player> players)
        {
            PlayersList = players;
        }
        public void Run()
        {
            if (PlayersList.Count < 4)
                AddBots(4 - PlayersList.Count);

        }

        public void AddBots(int count)
        {
            for (int i = 1; i <= count; i++)
                PlayersList.Add(new Bot(i.ToString()));
        }
        //public Dictionary<string, bool> Cards { get; set; }
=======
namespace GameUno
{
    public class Game : MarshalByRefObject
    {

        public Dictionary<string, bool> Cards { get; set; }


>>>>>>> 914e06f... GameUNO(16.05)
    }
}
