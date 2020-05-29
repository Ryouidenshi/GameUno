using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNOGAME.Models
{
    public enum ColorEnum
    {
        Red,
        Blue,
        Yellow,
        Green
    }
    public enum CardInscription
    {
        Zero,
        One,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Skip,
        TakeTwoCards,
        ChangeDirection
    }
    public class Card
    {
        public Card(string pic, ColorEnum color, CardInscription inscription, bool mark)
        {
            Picture = pic;
            Color = color;
            Inscription = inscription;
            Mark = mark;
        }
        public int Score = 10;
        public bool Mark;
        public string Picture;
        public static string BackPicture = "BackCard.jpg";
        public ColorEnum Color;
        public CardInscription Inscription;
    }
}
