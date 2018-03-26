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

        public void buildMenu(string menuMessage, string menuOptions)
        {
            Console.Clear();
            Console.WriteLine(menuMessage);
            Console.WriteLine(menuOptions);
        }

        //validate input method:
        public bool validateInput(List<string> expectedInput, string playerInput)
        {
            playerInput.ToLower();
            if (!expectedInput.Contains(playerInput))
            {
                return false;
            }
            return true;
        }

        //convert gesture to numeric value method:
        public int gestureToInt(string input)
        {
            input.ToLower();
            switch (input)
            {
                case "rock":
                    return 0;
                case "paper":
                    return 1;
                case "scissors":
                    return 2;
                case "lizard":
                    return 3;
                case "spock":
                    return 4;
                default:
                    return 5;
            }

        }

        //public void doRound(playerOneChoice, playerTwoChoice)

        // https://stackoverflow.com/questions/9553058/scalable-solution-for-rock-paper-scissor
        public int whoWins(int playerA, int playerB)
        {
            int whoWon = (5 + playerA - playerB) % 5;
            int returnValue = 0;

            if (whoWon == 1 || whoWon == 3) // player 1 wins
            {
                returnValue = 1;
                return returnValue;
            }
            else if (whoWon == 2 || whoWon == 4) // player 2 wins
            {
                returnValue = 2;
                return returnValue;
            }
            else if (whoWon == 0) // tie
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
