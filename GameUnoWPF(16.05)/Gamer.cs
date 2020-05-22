using System;
using System.Collections.Generic;
using System.Text;

namespace GameUnoWPF
{
    public class Gamer : MarshalByRefObject
    {
        protected Game Game { get; set; }
        public string Name { get; set; }
        public  SortedDictionary<string, Card> Alignment { get; set; }

        public Gamer(Game game, string name)
        {
            Game = game;
            Name = name;
            Alignment = new SortedDictionary<string, Card>();
        }

        public List<Card> ReturnAllCardsGamer()
        {
            var list = new List<Card>();
            foreach(var card in Alignment)
                list.Add(card.Value);
            return list;
        }

        public void AddCard(Card card, bool mark)
        {
            Alignment.Add(card.ToString(), card);
            mark = true;
        }
        public void RemoveCard(Card card, bool mark)
        {
            Alignment.Remove(card.ToString());
            mark = true;
        }
        public void Clear(Card card, bool mark)
        {
            Alignment.Clear();
            mark = true;
        }

        public void SkipStep()
        {
            var desk = new Desk();
            var allCardsOnDesk = desk.GetAllCardsOnDesk();
            var lastCard = allCardsOnDesk[allCardsOnDesk.Count-1];
            //if (lastCard.Picture == "SkipCard")
            //    NextPlayer(); 
            //Нужно будет создать метод, который пропускает игрока, не очень понимаю пока как это можно сделать
            //есть такая идея, что дать сначала всем игрокам флаг фолс, рандомно кому-то дать true, то есть возможность хода
            //и этот флаг будет тру, пока игрок не сходил, или время не прошло, после этого его флак превращется в фолс
            //и право на ход передаётся другим игрокам, ну и с концом игры также: всем фолс, когда у кого-то не останется карт
        }
    }
}
