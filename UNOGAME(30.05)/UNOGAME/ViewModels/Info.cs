using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using UNOGAME.Models;

namespace UNOGAME.ViewModels
{
    static class Info
    {
        public static string PlayerName = "Jhon";
        public static ImageSource GetCardPicture(string picture)
        {
            return new BitmapImage(new Uri("../Views/CardsWPF/" + picture + ".jpg", UriKind.Relative));
        }
        public static BoardInfo boardInfo = new BoardInfo(new List<Player>(),new List<Card>());
        public static UnoGame game; 
        public static void Update()
        {
            game.PlayersCardsCount = new string[]
            {
                boardInfo.PlayersCardsCounter[1],
                boardInfo.PlayersCardsCounter[2],
                boardInfo.PlayersCardsCounter[3]
            };
            game.PlayerNames = new string[] 
            { 
                boardInfo.PlayersNames[0],
                boardInfo.PlayersNames[1],
                boardInfo.PlayersNames[2],
                boardInfo.PlayersNames[3]
            };
        }
    }
}
