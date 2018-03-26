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

        public void pickGesture(List<string> gestures, string whichPlayer)
        {
            clearScreen();
            Console.WriteLine("{0} it's your turn", whichPlayer);
            Console.WriteLine("Please pick one: {0}, {1}, {2}, {3}, {4}", gestures[0], gestures[1], gestures[2], gestures[3], gestures[4]);
        }

        public void showGesture(List<string> gestures, string playerOneChoice, string playerTwoChoice)
        {
            Console.WriteLine("Player one picked {0}", playerOneChoice);
            Console.WriteLine("Player two picked {0}", playerTwoChoice);
        }

        public void gameInProgress(int whatRound)
        {
            clearScreen();
            Console.WriteLine("Round: {0}", Convert.ToString(whatRound));
        }
    }
}
