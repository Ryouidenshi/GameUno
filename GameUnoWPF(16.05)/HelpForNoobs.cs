using System;
using System.Collections.Generic;
using System.Text;

<<<<<<< HEAD
namespace GameUnoWPF
=======
namespace GameUno
>>>>>>> 914e06f... GameUNO(16.05)
{
    public class HelpForNoobs : MarshalByRefObject
    {
        private static string namePlayer = "p2";
        private static Desk desk = new Desk();
        private static Gamer gamer = new Gamer(game, namePlayer);
        private static Game game = new Game();
        public void ToPossibility()
        {
            var cardsOnDesk = Desk.cardsOnDesk;
            var lastCard = cardsOnDesk[cardsOnDesk.Count - 1];
            var color = lastCard.Color;
            var picture = lastCard.Picture;
            foreach(var card in gamer.ReturnAllCardsGamer())
            {
                if (card.Color == color || card.Picture == picture)
                    card.Mark = true;
            }
        }
    }
}
