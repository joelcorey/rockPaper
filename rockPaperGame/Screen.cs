using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaperGame
{
    class Screen
    {
        public void clearScreen()
        {
            Console.Clear();
        }

        public void mainMenu(List<string> gestures)
        {
            clearScreen();
            Console.WriteLine("Welcome to {0}, {1}, {2}, {3}, {4}", gestures[0], gestures[1], gestures[2], gestures[3], gestures[4]);
            Console.WriteLine("");
            Console.WriteLine("Verse (P)layer or (C)omputer?");
        }

        public void gameInProgress(int whatRound)
        {
            clearScreen();
            Console.WriteLine("Round: {0}", Convert.ToString(whatRound));
        }
    }
}
