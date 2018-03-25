using System;
using System.Collections.Generic;

namespace rockPaperGame
{
    class GameConfig
    {
        public string gameState = "verseComputer";
        public int gameRound = 1;

        public List<string> gestures = new List<string>(new string[] {
            "rock",
            "paper",
            "scissors",
            "lizard",
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
