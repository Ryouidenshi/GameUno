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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace UNOGAME.Views
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class WinnerWindow : Window
    {
        public WinnerWindow()
        {
            InitializeComponent();
        }

        private void ShowLables()
        {
            var rnd = new Random();
            switch (rnd.Next(4))
            {
                case 1:
                    first.Visibility = Visibility.Visible;
                    third.Visibility = Visibility.Visible;
                    second.Visibility = Visibility.Hidden;
                    fourth.Visibility = Visibility.Hidden;
                    break;
                case 2:
                    second.Visibility = Visibility.Visible;
                    third.Visibility = Visibility.Visible;
                    first.Visibility = Visibility.Hidden;
                    fourth.Visibility = Visibility.Hidden;
                    break;
                case 3:
                    fourth.Visibility = Visibility.Visible;
                    third.Visibility = Visibility.Visible;
                    second.Visibility = Visibility.Hidden;
                    first.Visibility = Visibility.Hidden;
                    break;
                case 4:
                    first.Visibility = Visibility.Visible;
                    third.Visibility = Visibility.Visible;
                    second.Visibility = Visibility.Visible;
                    fourth.Visibility = Visibility.Visible;
                    break;
            }
        }

        private void MediaElement_MediaEnded(object sender, RoutedEventArgs e)
        {
            gif.Position = TimeSpan.FromMilliseconds(1);
            gif.Play();
            ShowLables();
        }
    }
}
