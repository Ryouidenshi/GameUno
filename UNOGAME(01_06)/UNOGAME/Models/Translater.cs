using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNOGAME.Models
{
    public class Translater
    {
        public static string[] Translate(List<bool> goldCards)
        {
            var borders = new string[20];
            for (int i = 0; i < goldCards.Count; i++)
            {
                if (goldCards[i])
                    borders[i] = "Gold";
                else
                    borders[i] = "Red";
            }
            return borders;
        }
        public static string[] Translate(List<Card> cards)
        {
            var array = new string[20];
            for (int i = 0; i < 20; i++)
            {
                if (i < cards.Count)
                    array[i] = "Visible";
                else
                    array[i] = "Hidden";
            }
            return array;
        }
        public static bool[] BoolTranslate(List<Card> cards)
        {
            var array = new bool[20];
            for (int i = 0; i < 20; i++)
            {
                if (i < cards.Count)
                    array[i] = true;
                else
                    array[i] = false;
            }
            return array;
        }
    }
}
