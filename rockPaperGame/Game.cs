using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaperGame
{
    class Game : GameConfig
    {
        Display display = new Display();

        public void gameStart()
        {
            display.buildMenu("Welcome to " + string.Join(" ", gestures.ToArray()), "Would you like to verse another (P)layer or the (C)omputer");
            List<string> acceptableInput = new List<string>(new string[] { "p", "c" });
            playerInput = Console.ReadLine();
            validationCheck = validateInput(acceptableInput, playerInput);
        }

        public void gameLoop(int roundLimit)
        {
            if (playerInput.ToLower() == "p" && validationCheck == true)
            {
                display.buildMenu("Player One please chose:", string.Join(" ", gestures.ToArray()));
                playerOneChoice = gestureToInt(Console.ReadLine());

                display.buildMenu("Player two please chose:", string.Join(" ", gestures.ToArray()));
                playerTwoChoice = gestureToInt(Console.ReadLine());
            }
            int decideWinner = whoWins(playerOneChoice, playerTwoChoice);
            displayWhoWon(decideWinner);
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

        public void displayWhoWon(int input) {
            if (input == 1)
            {
                Console.WriteLine("Player one wins with " + gestures[playerOneChoice]);
            }
                else if (input == 2)
            {
                Console.WriteLine("Player two wins with " + gestures[playerTwoChoice]);
            }
            else if (input == 3)
            {
                Console.WriteLine("It's a tie!");
            }
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
