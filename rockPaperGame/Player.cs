using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaperGame
{
    class Player
    {
        protected string name;
        protected int score;
        protected int wins;
        protected List<string> gestures;
        protected bool validationCheck = false;
        protected string playerChoice;

        public Player(string name, int score, int wins, List<string> gestures)
        {
            this.name = name;
            this.score = score;
            this.wins = wins;
            this.gestures = gestures;
        }

        public virtual string GetGesture()
        {
            AskForGesture();
            playerChoice = Console.ReadLine();
            validationCheck = ValidateInput(gestures, playerChoice);
            if(validationCheck == false) { GetGesture(); }
            return playerChoice;
        }

        public void AskForGesture()
        {
            Console.Clear();
            Console.WriteLine("{0} please choose from the following: {1} ", name, string.Join(" ", gestures.ToArray()));
        }

        public bool ValidateInput(List<string> expectedInput, string playerInput)
        {
            playerInput.ToLower();
            if (!expectedInput.Contains(playerInput))
            {
                Console.WriteLine("Expected input: ");
                foreach (var e in expectedInput)
                {
                    Console.WriteLine(e);
                }
                return false;
            }
            return true;
        }

        public string getName()
        {
            return name;
        }

        public int GetScore()
        {
            return score;
        }

        public void IncreaseScore(int increment)
        {
            score += increment;
        }
    }
}
