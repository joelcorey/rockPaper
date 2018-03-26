using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaperGame
{
    class Program
    {
        static void Main(string[] args)
        {

            // consistent commits. 
            // incorporate inheritance into game.
            // account for and handle bad user input, ensuring that any user input is validated and reobtained if necessary.
            // store all of the gesture options / choices in a List< T >.
            // the correct player to win a given round based on the choices*made by each player.
            // the game of RPSLS to be at minimum a ‘best of three’ to decide a winner.
            // option of a single player (human vs AI) or a multiplayer(human vs human) game.

            GameState gameState = new GameState();
            Screen screen = new Screen();

            gameState.buildMenu("Welcome to " + string.Join(" ", gameState.gestures.ToArray()), "Would you like to verse another (P)layer or the (C)omputer");
            List<string> acceptableInput = new List<string>(new string[] { "p", "c" });
            gameState.playerInput = Console.ReadLine();
            gameState.validationCheck = gameState.validateInput(acceptableInput, gameState.playerInput);

            if (gameState.mainChoice.ToLower() == "p" && gameState.validationCheck == true)
            {
                gameState.buildMenu(gameState.currentPlayer + " please chose:", string.Join(" ", gameState.gestures.ToArray()));
            }
            
            

            //gameState.playerOneChoice = Console.ReadLine();

            //gameState.playPlayer(gameState.gameState);
            //screen.showGesture()
            int decideWinner = gameState.whoWins(0, 1);
            Console.WriteLine(decideWinner);
            //gameConfig.makeList();
            Console.ReadLine();
            
        }
    }
}
