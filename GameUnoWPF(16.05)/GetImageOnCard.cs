using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using static System.Net.Mime.MediaTypeNames;

namespace GameUnoWPF
{
    public class GetImageOnCard
    {
        public ImageSource GetCard(Card card, ImageSource imageSouce)
        {
            if(card.Picture == "BlackChangeColor")
                return new BitmapImage(new Uri("CardsWPF/ChangeColor.jpg", UriKind.Relative));
            if (card.Picture == "BlackChangeTake")
                return new BitmapImage(new Uri("CardsWPF/ChangeColorAndTake4Cards.jpg", UriKind.Relative));
            return new BitmapImage(new Uri("CardsWPF/"+card.Picture+".jpg", UriKind.Relative));
        }
    }
}
