using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            player.Stop();
            Game game = new Game(new List<Player> { new Player(PlayerName.Text) });
            this.Hide();
            var winner = game.Run();
            MessageBox.Show(winner.Name);
            this.Show();
        }
        MediaPlayer player = new MediaPlayer();
        bool play = false;
        private void PlayerName_LayoutUpdated(object sender, EventArgs e)
        {
            if (PlayerName.Text == "СССР" && !play)
            {
                ImageBrush myBrush = new ImageBrush();
                myBrush.ImageSource = new BitmapImage(new Uri("Images/CCCP.png", UriKind.Relative));
                Back.Background = myBrush;
                player.Open(new Uri("Music/Hymn.mp3", UriKind.RelativeOrAbsolute));
                player.Play();
                play = true;
            }

        }
    }
}
