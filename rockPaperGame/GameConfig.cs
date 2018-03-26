using System;
using System.Collections.Generic;

namespace rockPaperGame
{
    class GameConfig
    {
        public string menuMessage = "";
        public string menuOptions = "";
        public string mainChoice = "";
        public string playerInput;
        public string gameState = "verseComputer";
        public int gameRound = 1;
        public int roundLimit = 3;
        public string currentPlayer = "Player one";
        public int playerOneChoice;
        public int playerTwoChoice;
        public bool validationCheck = false;

        public List<string> gestures = new List<string>(new string[] {
            "Rock",
            "Paper",
            "Scissors",
            "Lizard",
            "Spock"
        });

        public List<string> rules = new List<string>(new string[] {
            "Rock crushes Scissors",
            "Scissors cuts Paper",
            "Paper covers Rock",
            "Rock crushes Lizard",
            "Lizard poisons Spock",
            "Spock smashes Scissors",
            "Scissors decapitates Lizard",
            "Lizard eats Paper",
            "Paper disproves Spock",
            "Spock vaporizes Rock"
        } );

    }

}
