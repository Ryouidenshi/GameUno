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
        public static string winner;
        public static string PlayerName = "Jhon";
        public static ImageSource GetCardPicture(string picture)
        {
            return new BitmapImage(new Uri("CardsWPF/" + picture + ".jpg", UriKind.Relative));
        }
        public static BoardInfo boardInfo;
        public static UnoGame game;
        public static int currentCard = -1;
        public static bool mark = false;
        public static Dictionary<int, bool> MarkCards = new Dictionary<int, bool>();
        public static void Update()
        {
            if(boardInfo.centralCard != null)   
                game.CentralCard = GetCardPicture(boardInfo.centralCard.Picture);
            game.PlayersCardsCount = boardInfo.PlayersCardsCounter.ToArray();
            game.PlayerNames = boardInfo.PlayersNames.ToArray();
            var images = new List<ImageSource>();
            foreach (var img in boardInfo.Pictures)
                images.Add(GetCardPicture(img));
            game.ButtonPictures = images.ToArray();
        }
    }
}
