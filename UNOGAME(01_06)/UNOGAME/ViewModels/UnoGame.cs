using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;
using UNOGAME.Models;

namespace UNOGAME.ViewModels
{
    class UnoGame : ViewModelBase
    {
        static readonly DispatcherTimer timer = new DispatcherTimer();
        public UnoGame()
        {
            timer.Interval = TimeSpan.FromSeconds(0.1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        void Timer_Tick(object sender, EventArgs e)
        {
            Info.game = this;
            Info.Update();
            //if (Info.winner != null)
        }

        #region
        private string[] playerNames;
        public string[] PlayerNames
        {
            get { return playerNames; }
            set
            {
                playerNames = value;
                RaisePropertyChanged(() => PlayerNames);
            }
        } 
        private string[] playersCardsCount;
        public string[] PlayersCardsCount
        {
            get { return playersCardsCount; }
            set
            {
                playersCardsCount = value;
                RaisePropertyChanged(() => PlayersCardsCount);
            }
        }
        #endregion
        private ImageSource[] buttonPictures;
        public ImageSource[] ButtonPictures
        {
            get { return buttonPictures; }
            set
            {
                buttonPictures = value;
                RaisePropertyChanged(() => ButtonPictures);
            }
        }

        private string[] cardBorders;
        public string[] CardBorders
        {
            get { return cardBorders; }
            set
            {
                cardBorders = value;
                RaisePropertyChanged(() => CardBorders);
            }
        }

        private string[] visibleCards;
        public string[] VisibleCards
        {
            get { return visibleCards; }
            set
            {
                visibleCards = value;
                RaisePropertyChanged(() => VisibleCards);
            }
        }
        private bool[] enabledCards;
        public bool[] EnabledCards
        {
            get { return enabledCards; }
            set
            {
                enabledCards = value;
                RaisePropertyChanged(() => EnabledCards);
            }
        }

        private ImageSource centralCard;
        public ImageSource CentralCard
        {
            get { return centralCard; }
            set
            {
                centralCard = value;
                RaisePropertyChanged(() => CentralCard);
            }
        }
        public ICommand Button0
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    Info.currentCard = 0;
                    Info.mark = true;
                });
            }
        }
        public ICommand Button1
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    Info.currentCard = 1;
                    Info.mark = true;
                });
            }
        }
        public ICommand Button2
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    Info.currentCard = 2;
                    Info.mark = true;
                });
            }
        }
        public ICommand Button3
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    Info.currentCard = 3;
                    Info.mark = true;
                });
            }
        }
        public ICommand Button4
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    Info.currentCard = 4;
                    Info.mark = true;
                });
            }
        }
        public ICommand Button5
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    Info.currentCard = 5;
                    Info.mark = true;
                });
            }
        }
        public ICommand Button6
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    Info.currentCard = 6;
                    Info.mark = true;
                });
            }
        }
        public ICommand Button7
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    Info.currentCard = 7;
                    Info.mark = true;
                });
            }
        }
        public ICommand Button8
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    Info.currentCard = 8;
                    Info.mark = true;
                });
            }
        }
        public ICommand Button9
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    Info.currentCard = 9;
                    Info.mark = true;
                });
            }
        }
        public ICommand Button10
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    Info.currentCard = 10;
                    Info.mark = true;
                });
            }
        }
        public ICommand Button11
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    Info.currentCard = 11;
                    Info.mark = true;
                });
            }
        }
        public ICommand Button12
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    Info.currentCard = 12;
                    Info.mark = true;
                });
            }
        }
        public ICommand Button13
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    Info.currentCard = 13;
                    Info.mark = true;
                });
            }
        }
        public ICommand Button14
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    Info.currentCard = 14;
                    Info.mark = true;
                });
            }
        }
        public ICommand Button15
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    Info.currentCard = 15;
                    Info.mark = true;
                });
            }
        }
        public ICommand Button16
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    Info.currentCard = 16;
                    Info.mark = true;
                });
            }
        }
        public ICommand Button17
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    Info.currentCard = 17;
                    Info.mark = true;
                });
            }
        }
        public ICommand Button18
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    Info.currentCard = 18;
                    Info.mark = true;
                });
            }
        }
        public ICommand Button19
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    Info.currentCard = 19;
                    Info.mark = true;
                });
            }
        }

    }
}
