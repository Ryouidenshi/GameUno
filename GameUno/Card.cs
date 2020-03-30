using System;
using System.Collections.Generic;
using System.Text;

namespace GameUno
{
    public enum Color
    {
        Red,
        Blue,
        Yellow,
        Green,
        Black
    }
    public enum CardInfo
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
        SkipCard,
        TakeTwoCards,
        ChangeDirection,
        ChangeColor,
        ChangeColorAndTake4Cards
    }
    public class Card
    {
        public Card(string pic, Color color, CardInfo active, bool mark)
        {
            Picture = pic;
            Color = color;
            Active = active;
            Mark = mark;
        }
        public bool Mark;
        public string Picture;
        public static string BackPicture = "BackCard.jpg";
        public Color Color;
        public CardInfo Active;
        public override string ToString()
        {
            return Active.ToString();
        }
    }
}
