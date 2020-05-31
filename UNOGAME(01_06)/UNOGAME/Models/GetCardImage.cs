using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;
// это ненужная хня, потом удалим
namespace UNOGAME.Models
{
    class GetCardImage
    {
        public static ImageSource GetCard(Card card)
        {
            return new BitmapImage(new Uri("../Views/CardsWPF/" + card.Picture + ".jpg", UriKind.Relative));
        }
    }
}
