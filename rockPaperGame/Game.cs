using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaperGame
{
    class Game : GameConfig
    {
        Player playerOne;
        Player playerTwo;
        Display display;  

        public void GameStart()
        {
            while (!validationCheck)
            {
                display = new Display();
                display.BuildMenu("Welcome to " + string.Join(" ", gestures.ToArray()), "Would you like to verse another (P)layer or the (C)omputer");
                List<string> acceptableInput = new List<string>(new string[] { "p", "c" });
                mainMenuChoice = Console.ReadLine();
                validationCheck = ValidateInput(acceptableInput, mainMenuChoice);
            }
        }

        public void GameLoop()
        {
            playerOne = new Player("Player one", 0, 0, gestures);

            if (mainMenuChoice == "c")
            {
                playerTwo = new Computer("Player two", 0, 0, gestures);
            }
            else
            {
                playerTwo = new Player("Player two", 0, 0, gestures);
            }

            while (round <= limit)
            {
                playerOneChoice = playerOne.GetGesture();
                playerTwoChoice = playerTwo.GetGesture();

                int decideWinner = WhoWins(GestureToInt(playerOneChoice), GestureToInt(playerTwoChoice));

                if (decideWinner == 1)
                {
                    playerOne.IncreaseScore(1);
                }
                else if (decideWinner == 2)
                {
                    playerTwo.IncreaseScore(1);
                }

                DisplayWhoWon(decideWinner, playerOne.getName(), playerOne.GetScore(), playerTwo.getName(), playerTwo.GetScore());
                DisplayWinText(playerOneChoice, playerTwoChoice, gestures);
                round += 1;
                Console.WriteLine("When you are ready to proceed, press a key");
                Console.ReadLine();
            }

            OverallWinner(playerOne.GetScore(), playerTwo.GetScore());
        }

        public void DisplayWinText(string playerOneChoice, string playerTwoChoice, List<string> rules)
        {
            foreach (var r in rules)
            {
                if (r.Contains(playerOneChoice) && r.Contains(playerTwoChoice))
                {
                    Console.WriteLine(r);
                }
            }
        }

        public void OverallWinner(int playerOneScore, int playerTwoScore)
        {
            if (playerOneScore > playerTwoScore)
            {
                Console.WriteLine("Player one is the over all winner");
            }
            else if (playerOneScore < playerTwoScore)
            {
                Console.WriteLine("Player two is the over all winner");
            }
            else
            {
                Console.WriteLine("Impossible! A tie?!");
            }
        }

        public void EndGame()
        {
            //Console.Clear();
            Console.WriteLine("Thanks for playing!");
            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
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

        public void DisplayWhoWon(int determineWinner, string playerOneName, int playerOneScore, string playerTwoName, int playerTwoScore) {
            Console.Clear();
            Console.WriteLine("{0} chose {1} and has a score of: {2}", playerOneName, playerOneChoice, playerOneScore);
            Console.WriteLine("{0} chose {1} and has a score of: {2}", playerTwoName, playerTwoChoice, playerTwoScore);
            if (determineWinner == 1)
            {
                Console.WriteLine("Player one wins");
            }
            else if (determineWinner == 2)
            {
                Console.WriteLine("Player two wins");
            }
            else if (determineWinner == 3)
            {
                Console.WriteLine("It's a tie!");
            }
        }

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

        // https://stackoverflow.com/questions/9553058/scalable-solution-for-rock-paper-scissor
        public int WhoWins(int playerOne, int playerTwo)
        {
            int whoWon = (5 + playerOne - playerTwo) % 5;
            int returnValue = 0;

            if (whoWon == 0)
            {
                returnValue = 3;
                return returnValue;
            }
            else if (whoWon == 1 || whoWon == 3)
            {
                
                returnValue = 1;
                return returnValue;
            }
            else if (whoWon == 2 || whoWon == 4)
            {
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
