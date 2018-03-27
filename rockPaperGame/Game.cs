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

        public void GameStart()
        {
            display.buildMenu("Welcome to " + string.Join(" ", gestures.ToArray()), "Would you like to verse another (P)layer or the (C)omputer");
            List<string> acceptableInput = new List<string>(new string[] { "p", "c" });
            playerInput = Console.ReadLine();
            validationCheck = validateInput(acceptableInput, playerInput);

            if (validationCheck == true)
            {
                GameLoop(roundLimit);
            }
            else
            {
                GameStart();
            }

        }

        public void GameLoop(int roundLimit)
        {
            //if (playerInput.ToLower() == "p" && validationCheck == true)
            //{
                display.buildMenu("Player One please chose:", string.Join(" ", gestures.ToArray()));
                playerOneChoice = (Console.ReadLine());

                display.buildMenu("Player two please chose:", string.Join(" ", gestures.ToArray()));
                playerTwoChoice = (Console.ReadLine());

                playerOneNumber = GestureToInt(playerOneChoice);
                playerTwoNumber = GestureToInt(playerTwoChoice);
            //}

            Console.WriteLine("Player one numeric choice: " + playerOneChoice);
            Console.WriteLine("Player two numeric choice " + playerTwoChoice);

            int decideWinner = WhoWins(playerOneNumber, playerTwoNumber);
            DisplayWhoWon(decideWinner);
        }

        public bool ValidateInput(List<string> expectedInput, string playerInput)
        {
            playerInput.ToLower();
            if (!expectedInput.Contains(playerInput))
            {
                return false;
            }
            return true;
        }

        public void DisplayWhoWon(int input) {
            Console.WriteLine("Player one chose: {0}", playerOneChoice);
            Console.WriteLine("Player one chose: {0}", playerTwoChoice);
            if (input == 1)
            {
                Console.WriteLine("Player one wins");
            }
            else if (input == 2)
            {
                Console.WriteLine("Player two wins");
            }
            else if (input == 3)
            {
                Console.WriteLine("It's a tie!");
            }
        }

        //convert gesture to numeric value method:
        public int GestureToInt(string input)
        {
            switch (input.ToLower())
            {
                case "rock":
                    return 1;
                case "paper":
                    return 2;
                case "scissors":
                    return 3;
                case "lizard":
                    return 5;
                case "spock":
                    return 4;
                default:
                    Console.WriteLine("Invalid gestureToInt({0})", input);
                    return 6;
            }
        }

        //public void doRound(playerOneChoice, playerTwoChoice)

        // https://stackoverflow.com/questions/9553058/scalable-solution-for-rock-paper-scissor
        public int WhoWins(int playerOne, int playerTwo)
        {
            int whoWon = (5 + playerOne - playerTwo) % 5;
            int returnValue = 0;

            if (whoWon == 0) // tie
            {
                Console.WriteLine("TIE: whoWins.whoWon = " + whoWon);
                returnValue = 3;
                return returnValue;
            }
            else if (whoWon == 1 || whoWon == 3) // player 1 wins
            {
                Console.WriteLine("PLAYER1 WINS: whoWins.whoWon = " + whoWon);
                returnValue = 1;
                return returnValue;
            }
            else if (whoWon == 2 || whoWon == 4) // player 2 wins
            {
                Console.WriteLine("PLAYER2 WINS: whoWins.whoWon = " + whoWon);
                returnValue = 2;
                return returnValue;
            }
            else
            {
                Console.WriteLine("Invalid else block reached, check whoWins case statement");
                return returnValue;
            }

        }

    }

}
