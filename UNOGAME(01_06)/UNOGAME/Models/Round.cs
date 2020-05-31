using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNOGAME.ViewModels;
using System.Threading;

namespace UNOGAME.Models
{
    public enum Direction
    {
        Сlockwise,
        СounterСlockwise
    }

    public enum SkipMove
    {
        Skip,
        NotSkip
    }
    public class Round
    {
        bool wastaking;
        Card CentralCard;
        Direction direction;
        SkipMove skipMove;
        int currentPlayer;
        public Deck RoundDeck { get; set; }
        public List<Player> PlayersList { get; set; }
        public BoardInfo BoardInfo;
        public Round(List<Player> players, int current)
        {
            RoundDeck = new Deck();
            PlayersList = players;
            currentPlayer = current;
        }
        public Tuple<Player, int> Run()
        {
            BoardInfo = new BoardInfo(PlayersList, PlayersList[0].CardList);
            Info.boardInfo = BoardInfo;
            GiveOutCardsToPlayers();
            bool isSomebodyWin = false;
            CentralCard = RoundDeck.Draw();
            BoardInfo.Update(PlayersList, PlayersList[0].CardList, CentralCard);
            Player winner = new Player("winner");
            while (!isSomebodyWin)
            {
                if(currentPlayer == 0)
                {
                    List<bool> isAvailible = new List<bool>();
                    var listCardsPlayer = PlayersList[0].CardList;
                    for (int i = 0; i < listCardsPlayer.Count(); i++)
                    {
                        if (listCardsPlayer[i].Color == CentralCard.Color || listCardsPlayer[i].Inscription == CentralCard.Inscription)
                            isAvailible.Add(true);
                        else
                            isAvailible.Add(false);
                    }
                    var flag = false;
                    foreach (var bol in isAvailible)
                        if (bol)
                            flag = true;
                    if (!flag && !wastaking)
                    {
                        PlayersList[currentPlayer].CardList.Add(RoundDeck.Draw());
                        BoardInfo.Update(PlayersList, PlayersList[0].CardList, CentralCard);
                        wastaking = true;
                        continue;
                    }
                    else if(!flag && wastaking)
                    {
                        Thread.Sleep(150);
                        NextPlayer();
                        BoardInfo.Update(PlayersList, PlayersList[0].CardList, CentralCard);
                        continue;
                    }
                    Info.borders = Translater.Translate(isAvailible);
                    Info.visibleCards = Translater.Translate(PlayersList[0].CardList);
                    Info.enabledCards = Translater.BoolTranslate(PlayersList[0].CardList);
                    while (Info.mark == false){}
                    if (PlayersList[0].CardList[Info.currentCard].Color != CentralCard.Color
                        && PlayersList[0].CardList[Info.currentCard].Inscription != CentralCard.Inscription)
                    {
                        Info.mark = false;
                        continue;
                    }
                    var turn = Turn.MakeTurn(CentralCard, PlayersList[0].CardList[Info.currentCard]);
                    Update(turn, PlayersList[0].CardList[Info.currentCard]);
                    PlayersList[currentPlayer].CardList.RemoveAt(Info.currentCard);
                    Info.mark = false;
                    Thread.Sleep(150);
                }
                else
                {
                    var bot = PlayersList[currentPlayer] as Bot;
                    var turnResult = bot.MakeTurn(CentralCard);
                    if (turnResult == null)
                    {
                        bot.CardList.Add(RoundDeck.Draw());
                        var endTurnResult = bot.MakeTurnWithTakeCard(CentralCard);
                        if (endTurnResult != null) 
                        { 
                            Update(endTurnResult.Item2, endTurnResult.Item1);
                            PlayersList[currentPlayer].CardList.Remove(endTurnResult.Item1);
                        }
                    }
                    else Update(turnResult.Item2, turnResult.Item1);
                    if (turnResult != null)
                        PlayersList[currentPlayer].CardList.Remove(turnResult.Item1);
                }
                NextPlayer();
                for(int i=0;i<4;i++)
                    if (PlayersList[i].CardList.Count == 0)
                    {
                        winner = PlayersList[i];
                        isSomebodyWin = true;
                    }
                Thread.Sleep(250);
                BoardInfo.Update(PlayersList, PlayersList[0].CardList, CentralCard);
            }
            int score = 0;
            for (int i = 0; i < 4; i++)
                score += PlayersList[1].CardList.Count * 10;
            RoundDeck = new Deck();
            foreach(var player in PlayersList)
                player.CardList.Clear();
            return new Tuple<Player, int>(winner, score);
        }

        void GiveOutCardsToPlayers()
        {
            for (int i = 0; i < 7; i++)
            {
                foreach (var player in PlayersList)
                {
                    player.Take(RoundDeck.Draw());
                    BoardInfo.Update(PlayersList, PlayersList[0].CardList);
                    Thread.Sleep(150);
                }
            }
        }
        void Update(Turn turn, Card card)
        {
            CentralCard = card;
            if (turn.SkipMove)
                skipMove = SkipMove.Skip;
            if (turn.Take2cards)
            {
                PlayersList[currentPlayer].CardList.Add(RoundDeck.Draw());
                PlayersList[currentPlayer].CardList.Add(RoundDeck.Draw());
            }
            if (turn.ChangeDirection)
                if (direction == Direction.Сlockwise)
                    direction = Direction.СounterСlockwise;
                else direction = Direction.Сlockwise;
        }
        void NextPlayer()
        {
            if (direction == Direction.Сlockwise && skipMove == SkipMove.NotSkip && currentPlayer == 3)
                currentPlayer = 0;
            else if (direction == Direction.СounterСlockwise && skipMove == SkipMove.NotSkip && currentPlayer == 0)
                currentPlayer = 3;
            else if (direction == Direction.СounterСlockwise && skipMove == SkipMove.Skip && currentPlayer == 0)
                currentPlayer = 2;
            else if (direction == Direction.СounterСlockwise && skipMove == SkipMove.Skip && currentPlayer == 1)
                currentPlayer = 3;
            else if (direction == Direction.Сlockwise && skipMove == SkipMove.NotSkip)
                currentPlayer++;
            else if (direction == Direction.Сlockwise && skipMove == SkipMove.Skip)
                currentPlayer += 2;
            else if (direction == Direction.СounterСlockwise && skipMove == SkipMove.NotSkip)
                currentPlayer--;
            else if (direction == Direction.СounterСlockwise && skipMove == SkipMove.Skip)
                currentPlayer -= 2;
            if (currentPlayer == 5)
                currentPlayer = 1;
            if (currentPlayer == -1)
                currentPlayer = 3;
            if (currentPlayer == 4)
                currentPlayer = 0;
            skipMove = SkipMove.NotSkip;
        }
    }
}
