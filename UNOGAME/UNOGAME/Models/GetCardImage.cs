using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace UNOGAME.Models
{
    class GetCardImage
    {
        public ImageSource GetCard(Card card)
        {
            return new BitmapImage(new Uri("CardsWPF/" + card.Picture + ".jpg", UriKind.Relative));
        }
    }
}
