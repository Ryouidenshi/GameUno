using System;
using System.Collections.Generic;
using System.Text;

namespace GameUno
{
    public enum ColorEnum
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
        Skip,
        TakeTwoCards,
        ChangeDirection,
        ChangeColor,
        ChangeTake
    }
    public class Card
    {
        public Card(string pic, ColorEnum color, CardInfo active, bool mark)
        {
            Picture = pic;
            Color = color;
            Active = active;
            Mark = mark;
        }
        public bool Mark;
        public string Picture;
        public static string BackPicture = "BackCard.jpg";
        public ColorEnum Color;
        public CardInfo Active;
        public override string ToString()
        {
            return Active.ToString();
        }
    }
}
