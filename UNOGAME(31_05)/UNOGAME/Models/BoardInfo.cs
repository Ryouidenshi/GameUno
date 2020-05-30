using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using UNOGAME.ViewModels;

namespace UNOGAME.Models
{
    public class BoardInfo
    {
        public Card centralCard;
        public List<string> PlayersNames = new List<string>();
        public List<string> PlayersCardsCounter = new List<string>();
        public List<string> Pictures = new List<string>();
        public BoardInfo(List<Player> players, List<Card> cardList)
        {
            foreach (var player in players)
            {
                PlayersCardsCounter.Add(player.CardList.Count.ToString());
                PlayersNames.Add(player.Name);
            }
            foreach (var card in cardList)
                Pictures.Add(card.Picture);
        }
        
        public void Update(List<Player> players, List<Card> cardList)
        {
            for (int i = 0; i < players.Count; i++)
                PlayersCardsCounter[i] = players[i].CardList.Count.ToString();
            Pictures.Clear();
            foreach (var card in cardList)
                Pictures.Add(card.Picture);
        }
        public void Update(List<Player> players, List<Card> cardList, Card central)
        {
            centralCard = central;
            for (int i = 0; i < players.Count; i++)
                PlayersCardsCounter[i] = players[i].CardList.Count.ToString();
            Pictures.Clear();
            foreach (var card in cardList)
                Pictures.Add(card.Picture);
        }
    }
}
