using System;
using System.Collections.Generic;
using System.Text;

namespace GameUnoWPF
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
        public Card(string pic, ColorEnum color, CardInscription active, bool mark)
        {
            Picture = pic;
            Color = color;
            Active = active;
            Mark = mark;
        }
        public int Score = 10;
        public bool Mark;
        public string Picture;
        public static string BackPicture = "BackCard.jpg";
        public ColorEnum Color;
        public CardInscription Active;//inscription
        public override string ToString()
        {
            return Active.ToString();
        }
    }
}
