using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaperGame
{
    class Computer : Player
    {

        public Computer(string name, int score, int wins, List<string> gestures)
            : base(name, score, wins, gestures)
        {

        }

        public override string GetGesture()
        {
            Random rnd = new Random();
            int choice = rnd.Next(0, 4);
            playerChoice = gestures[choice];
            return playerChoice;
        }

    }
}
