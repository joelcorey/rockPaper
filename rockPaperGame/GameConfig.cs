using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaperGame
{
    class GameConfig
    {
        List<string> gestures = new List<string>(new string[] { "rock", "paper", "scissors", "lizard", "Spock" });

        public List<string> GetList()
        {
            return gestures;
        }

    }
     
}
