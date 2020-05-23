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
            return new BitmapImage(new Uri("CardsWPF/" + card.Picture + ".jpg", UriKind.Relative));
        }
    }
}
