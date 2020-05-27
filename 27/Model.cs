using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
namespace GameUnoWPF
{
    public class Model
    {
        Round Round { get; set; }
        Window window;
        BoardInfo BoardInfo { get; set; }
        public Model(Round round)
        {
            Round = round;
            BoardInfo = new BoardInfo(round.PlayersList, true, round.PlayersList[0].CardList);
            SetModel(BoardInfo);
        }
        public void Update(Round round)
        {
            Round = round;
            BoardInfo.Update(round.PlayersList, round.PlayersList[0].CardList);
        }
        [STAThread]
        void SetModel(BoardInfo info)
        {
            window = new MainWindow(info,this); 
            window.Show();
        }
        public void Close()
        {
            window.Close();
        }
    }
}
