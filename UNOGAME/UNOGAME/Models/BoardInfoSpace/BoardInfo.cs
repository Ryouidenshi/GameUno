using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using UNOGAME.ViewModels;

namespace UNOGAME.Models.BoardInfoSpace
{
    public class BoardInfo
    {
        public List<string> PlayersNames = new List<string>();
        public bool IsNotUpdate = false;
        public List<string> PlayersCardsCounter = new List<string>();
        public BoardInfo(List<Player> players, bool isUndate, List<Card> cardList)
        {
            IsNotUpdate = isUndate;
            foreach (var player in players)
            {
                PlayersNames.Add(player.Name);
                PlayersCardsCounter.Add(player.CardList.Count.ToString());
            }
        }
        public BoardInfo(List<Player> players, List<Card> cardList)
        {
            foreach (var player in players)
                PlayersCardsCounter.Add(player.CardList.Count.ToString());
        }

        public void Update(List<Player> players, List<Card> cardList)
        {
            for (int i = 0; i < players.Count; i++)
                PlayersCardsCounter[i] = players[i].CardList.Count.ToString();
        }
    }
}
