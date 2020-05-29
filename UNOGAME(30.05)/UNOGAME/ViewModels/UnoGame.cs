using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UNOGAME.Models;

namespace UNOGAME.ViewModels
{
    class UnoGame : ViewModelBase
    {
        public ICommand Command
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    Info.game = this;
                    Info.Update();
                });
            }
            
        }
        // Имена игроков
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
        // Кол-во карт других игроков
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
        
    }
}
