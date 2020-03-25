using System;
using System.Collections.Generic;
using System.Text;

namespace GameUno
{
    public class Gamer : MarshalByRefObject
    {
        protected Game Game { get; set; }
        public string Name { get; set; }
        public SortedDictionary<string, Card> Alignment { get; set; }

        public Gamer(Game game, string name)
        {
            Game = game;
            Name = name;
            Alignment = new SortedDictionary<string, Card>();
        }

        public void AddCard(Card card)
        {
            Alignment.Add(card.ToString(), card);
        }
        public void RemoveCard(Card card)
        {
            Alignment.Remove(card.ToString());
        }
        public void Clear(Card card)
        {
            Alignment.Clear();
        }
    }
}
