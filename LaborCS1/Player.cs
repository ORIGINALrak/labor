using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaborCS
{
    internal class Player
    {
        public Player(int x, int y)
        {
            playerPos = new Position(x, y);
            sprite = new ConsoleSprite(ConsoleColor.Black, ConsoleColor.Green, 'O');
        }

        Position playerPos;
        ConsoleSprite sprite;
        public Position Pos { get { return playerPos; } set { playerPos = value; } }
        public ConsoleSprite Sprite { get { return sprite; } set; }

    }
}
