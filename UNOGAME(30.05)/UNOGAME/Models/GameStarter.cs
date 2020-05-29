using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNOGAME.Models
{
    public static class GameStarter
    {
        public static void StartGame(string name)
        {
            Game game = new Game(new List<Player> { new Player(name) });
            game.Run();
        }
    }
}
