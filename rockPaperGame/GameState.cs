using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaperGame
{
    class GameState : GameConfig
    {

        public void playPlayer(string state)
        {
            if (state == "verseComputer")
            {
                Console.WriteLine(state);
            }
        }

        //validate input method:
        public void validateInput<T>(IEnumerable<T> list)
        {
            foreach (var l in list)
            {
                Console.WriteLine(l);
            }
        }


       //convert gesture to numeric value method:

        // https://stackoverflow.com/questions/9553058/scalable-solution-for-rock-paper-scissor
        public int whoWins(int playerA, int playerB)
        {
            int whoWon = (5 + playerA - playerB) % 5;
            int returnValue = 0;

            if (whoWon == 1 || whoWon == 3)
            {
                returnValue = 1;
                return returnValue;
            }
            else if (whoWon == 2 || whoWon == 4)
            {
                returnValue = 2;
                return returnValue;
            }
            else if (whoWon == 0)
            {
                returnValue = 3;
                return returnValue;
            }
            else
            {
                return returnValue;
            }

        }

    }

}
