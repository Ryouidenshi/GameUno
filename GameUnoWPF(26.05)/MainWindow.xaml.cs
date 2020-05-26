using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GameUnoWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly Player player1 = new Player("first");
        readonly Player player2;
        readonly Player player3;
        readonly Player player4;
        public MainWindow()
        {
            InitializeComponent();
            var countCardAtPlayer = player1.CardList.Count;
            for (int i = 0; i < 10; i++)
            {
                if (countCardAtPlayer < 10)
                {
                    var card = dec.Draw();
                    player1.CardList.Add(card);
                    Image img = new Image();
                    var getImageOnCard = new GetImageOnCard();
                    var getCardImage = getImageOnCard.GetCard(card, null);
                    img.Source = getCardImage;
                    Button btn = new Button();
                    btn.Click += ClickOnCardsPlayer_Click;
                    btn.Name = card.Active.ToString();
                    btn.Content = img;
                    btn.RenderTransformOrigin = new Point(0.5, 0.5);
                    Grid.SetColumn(btn, x);
                    Player1.Children.Add(btn);
                    x++;
                }
            }
        }
        Turn turn = new Turn();
        Deck dec = new Deck();
        public int x=0;

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var countCardAtPlayer = player1.CardList.Count;
            if (countCardAtPlayer < 10)
            {
                var card = dec.Draw();
                player1.CardList.Add(card);
                Image img = new Image();
                var getImageOnCard = new GetImageOnCard();
                var getCardImage = getImageOnCard.GetCard(card, null);
                img.Source = getCardImage;
                Button btn = new Button();
                btn.Click += ClickOnCardsPlayer_Click;
                btn.Name = card.Active.ToString();
                btn.Content = img;
                btn.RenderTransformOrigin = new Point(0.5, 0.5);
                Grid.SetColumn(btn, x);
                Player1.Children.Add(btn);
                x++;
            }
        }

        private void ClickOnCardsPlayer_Click(object sender, EventArgs e)
        {
            var rules = new Rules(player1);
            var but = sender as Button;
            rules.GetPropertiesSelectCard(but.Name, turn);
            rules.GetMarkOnCards(dec, dec.CardOnDesk(), turn);
            Player1.Children.Remove(but);

        }

        private void Button_Initialized(object sender, EventArgs e)
        {
            var card = dec.CardOnDesk();
            dec.Draw();
            var img = new Image();
            var getImageOnCard = new GetImageOnCard();
            var getCardImage = getImageOnCard.GetCard(card, null);
            img.Source = getCardImage;
            heap.Name = card.Picture;
            heap.Content = img;
        }
    }
}
