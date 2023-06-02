using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Zmej
{
    class Osn
    {
        static void Main(string[] args)
        {
            Game game = new Game(80, 25);
            game.Run();

            Game.ShowLeaderboard(10);
        }        
    }
}
