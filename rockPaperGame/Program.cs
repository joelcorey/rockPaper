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

            Game game = new Game();
            game.GameStart();
            game.GameLoop();
            game.EndGame();

            
        }
    }
}
