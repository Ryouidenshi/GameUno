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
        BoardInfo boardInfo;
        Model model;
        public MainWindow(BoardInfo boardInfo, Model model)
        {
            this.model = model;
            this.boardInfo = boardInfo;
            InitializeComponent();
            MainPlayer.Text = this.boardInfo.PlayersNames[0];
            SecondPlayerName.Text = this.boardInfo.PlayersNames[1];
            ThirdPlayerName.Text = this.boardInfo.PlayersNames[2];
            FourthPlayerName.Text = this.boardInfo.PlayersNames[3];
            SecondPlayerCards.Text = this.boardInfo.PlayersCardsCounter[1];
            ThirdPlayerCards.Text = this.boardInfo.PlayersCardsCounter[2];
            FourthPlayerCards.Text = this.boardInfo.PlayersCardsCounter[3];
            for (int i=0; i < this.boardInfo.ButtonsCount; i++)
            {
                if(this.boardInfo.MainPlayerButtons[i] != null)
                {
                    this.boardInfo.MainPlayerButtons[i].Click += MainWindow_Click;
                    Grid.SetColumn(this.boardInfo.MainPlayerButtons[i], i);
                    PlayerBoard.Children.Add(this.boardInfo.MainPlayerButtons[i]);
                }
            }
        }

        private void _Initialized()
        {

        }
        private void MainWindow_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("1");
        }

        private void TakeCard(object sender, RoutedEventArgs e)
        {
            //var countCardAtPlayer = player1.CardList.Count;
            //var card = dec.Draw();
            //player1.CardList.Add(card);
            //Image img = new Image();
            //var getImageOnCard = new GetImageOnCard();
            //var getCardImage = getImageOnCard.GetCard(card, null);
            //img.Source = getCardImage;
            //Button btn = new Button();
            //btn.Name = card.Picture;
            //btn.Content = img;
            //btn.RenderTransformOrigin = new Point(0.5, 0.5);
            //Grid.SetColumn(btn, x);
            //Player1.Children.Add(btn);
            //x++; 
            //if (countCardAtPlayer > 20)
            //{
            //    MessageBox.Show("Loser");
            //    this.Close();
            //}
        }

        private void Button_Initialized(object sender, EventArgs e)
        {
            //var card = dec.Draw();
            //var img = new Image();
            //var getImageOnCard = new GetImageOnCard();
            //var getCardImage = getImageOnCard.GetCard(card, null);
            //img.Source = getCardImage;
            //heap.Name = card.Picture;
            //heap.Content = img;
        }
    }
}
