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

            // commit consistently
            // properly incorporate inheritance
            // 

            GameConfig gameConfig = new GameConfig();
            
            foreach (var gesture in gameConfig.gestures)
            {
                Console.WriteLine(gesture);
            }
        }
    }
}
