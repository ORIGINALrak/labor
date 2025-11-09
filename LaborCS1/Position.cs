using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LaborCS
{
    internal class Position
    {
        public Position(int posx, int posy)
        {
            this.x = posx;
            this.y = posy;
        }

        int x;
        int y;
        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }

        public static Position Add(Position p_1, Position p_2)
        {
            return new Position(p_1.x + p_2.x, p_1.y + p_2.y);
        }
        public static double Distance(Position p_1, Position p_2)
        {
            return Math.Sqrt((p_1.x - p_2.x) * (p_1.y - p_2.y)+ (p_1.y- p_2.y));
        }
    }
}
