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
        public Bot(string name) : base(name)
        {
            Name = GetRandomName();
        }

        //public void MakeTurn(Card topCard)
        //{

        //}
        public string GetRandomName()
        {
            var rnd = new Random();
            var file = File.ReadAllText("BotNames.txt");
            var splitedFile = file.Split();
            for (int i=0; i<splitedFile.Count();i++)
            {
                int j = rnd.Next(splitedFile.Count());
                string tmp = splitedFile[i];
                splitedFile[i] = splitedFile[j];
                splitedFile[j] = tmp;
            }
            return splitedFile[rnd.Next(splitedFile.Count())];
        }
    }
}
