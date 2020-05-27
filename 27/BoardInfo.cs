using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace GameUnoWPF
{
    public class BoardInfo
    {
        public List<string> PlayersNames = new List<string>();
        public bool IsNotUpdate = false;
        public List<string> PlayersCardsCounter = new List<string>();
        public List<Button> MainPlayerButtons = new List<Button>();
        public int ButtonsCount { get { return MainPlayerButtons.Count; } }
        public BoardInfo(List<Player> players, bool isUndate, List<Card> cardList)
        {
            IsNotUpdate = isUndate;
            foreach (var player in players)
            {
                PlayersNames.Add(player.Name);
                PlayersCardsCounter.Add(player.CardList.Count.ToString());
            }
            for(int i = 0; i < 20; i++)
            {
                if (i < cardList.Count)
                    MainPlayerButtons.Add(GetButton(cardList[i]));
                else
                    MainPlayerButtons.Add(null);
            }
        }
        public BoardInfo(List<Player> players, List<Card> cardList)
        {
            foreach (var player in players)
                PlayersCardsCounter.Add(player.CardList.Count.ToString());
            foreach (var card in cardList)
                MainPlayerButtons.Add(GetButton(card));
        }
        Button GetButton(Card card)
        {
            Image img = new Image();
            var getImageOnCard = new GetImageOnCard();
            var getCardImage = getImageOnCard.GetCard(card, null);
            img.Source = getCardImage;
            Button btn = new Button
            {
                Name = card.Picture,
                Content = img,
                RenderTransformOrigin = new Point(0.5, 0.5)
            };
            return btn;
        }
        public void Update(List<Player> players, List<Card> cardList)
        {
            for (int i = 0; i < players.Count; i++)
                PlayersCardsCounter[i] = players[i].CardList.Count.ToString();
            MainPlayerButtons.Clear();
            for (int i = 0; i < 20; i++)
            {
                if (i < cardList.Count)
                    MainPlayerButtons.Add(GetButton(cardList[i]));
                else
                    MainPlayerButtons.Add(null);
            }
        }
    }
}
