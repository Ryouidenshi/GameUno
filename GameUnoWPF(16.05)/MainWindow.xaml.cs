<<<<<<< HEAD
﻿using System;
=======
﻿using GameUno;
using System;
>>>>>>> 914e06f... GameUNO(16.05)
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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Deck dec = new Deck();
        public int x=0;
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var card = dec.Draw();

            Image img = new Image();
            var getImageOnCard = new GetImageOnCard();
            var getCardImage = getImageOnCard.GetCard(card, null);
            img.Source = getCardImage;
            Button btn = new Button();
            btn.Content = img;
            btn.Height = 104;
            btn.Width = 88;
            btn.RenderTransformOrigin = new Point(0.5,0.5);
            Grid.SetColumn(btn, x);
            Player1.Children.Add(btn);
            x++;

        }

    }
}
