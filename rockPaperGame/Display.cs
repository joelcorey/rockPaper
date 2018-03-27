using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaperGame
{
    class Display
    {
        public void BuildMenu(string menuMessage, string menuOptions)
        {
            Console.Clear();
            Console.WriteLine(menuMessage);
            Console.WriteLine(menuOptions);
        }
    }
}
