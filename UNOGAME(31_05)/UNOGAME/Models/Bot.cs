using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNOGAME.Models
{
    public class Bot : Player
    {
        public static List<string> BotNames;
        public Bot(string name) : base(name)
        {
            Name = GetRandomName();
        }

        public Tuple<Card,Turn> MakeTurn(Card topCard)
        {
            foreach (var card in CardList)
                if (card.Color == topCard.Color || card.Inscription == topCard.Inscription)
                    return new Tuple<Card, Turn>(card, Turn.MakeTurn(topCard, card));
            return null;
        }
        public Tuple<Card, Turn> MakeTurnWithTakeCard(Card topCard)
        {
            Card card = this.CardList[CardList.Count - 1];
            if (card.Color == topCard.Color || card.Inscription == topCard.Inscription)
                return new Tuple<Card, Turn>(card, Turn.MakeTurn(topCard, card));
            return null;
        }
        public static void CreateBotNames()
        {
            var file = File.ReadAllText("BotNames.txt");
            BotNames = file.Split(' ', '\n', '\r', '\t').Where(x => x != "").ToList();
        }
        public string GetRandomName()
        {
            var rnd = new Random();
            var current = rnd.Next(BotNames.Count() - 1);
            var name = BotNames[current];
            BotNames.RemoveAt(current);
            return name;
        }
    }
}
