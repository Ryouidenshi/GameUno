using System;
using System.Collections.Generic;
using System.Text;

<<<<<<< HEAD
namespace GameUnoWPF
=======
namespace GameUno
>>>>>>> 914e06f... GameUNO(16.05)
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
<<<<<<< HEAD
    }//CardInscription
=======
    }
>>>>>>> 914e06f... GameUNO(16.05)
    public class Card
    {
        public Card(string pic, ColorEnum color, CardInfo active, bool mark)
        {
            Picture = pic;
            Color = color;
            Active = active;
            Mark = mark;
        }
<<<<<<< HEAD
        public int Score = 10;
=======
>>>>>>> 914e06f... GameUNO(16.05)
        public bool Mark;
        public string Picture;
        public static string BackPicture = "BackCard.jpg";
        public ColorEnum Color;
<<<<<<< HEAD
        public CardInfo Active;//inscription
=======
        public CardInfo Active;
>>>>>>> 914e06f... GameUNO(16.05)
        public override string ToString()
        {
            return Active.ToString();
        }
    }
}
