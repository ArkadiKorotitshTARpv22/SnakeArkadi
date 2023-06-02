using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmej
{
    class FoodCreator
    {
        private int mapWidth;
        private int mapHeight;
        private char foodsym;


        Random random = new Random();

        public FoodCreator
            (
                        int mapWidth, 
                        int mapHeight, 
                        char foodsym
            )
        {
            this.mapWidth = mapWidth;
            this.mapHeight = mapHeight;
            this.foodsym = foodsym;
        }

        public Point CreateFood()
        {
            int x = random.Next(2, mapWidth - 2);
            int y = random.Next(2, mapHeight - 2);

            if (random.Next(1, 101) < 11)
            {
                return new Point(x, y, 'O');
            }
            else if (random.Next(1, 101) < 71)
            {
                return new Point(x, y, 'o');
            }
            else if (random.Next(1, 101) < 2)
            {
                return new Point(x, y, '*');
            }
            else
            {
                return new Point(x, y, '#');
            }
        }
    }
}
