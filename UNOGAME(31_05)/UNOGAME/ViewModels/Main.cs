using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UNOGAME.Models;
using UNOGAME.Views;

namespace UNOGAME.ViewModels
{
    class Main : ViewModelBase
    {
        private static string name = Info.PlayerName;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                RaisePropertyChanged(() => Name);
            }
        }
        public ICommand StartGame
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    Info.PlayerName = name;
                    UNO_Game gameWindow = new UNO_Game();
                    gameWindow.Show();
                    Task startGame = new Task( ()=> GameStarter.StartGame(name) );
                    startGame.Start();
                });
            }
        }
    }
}
