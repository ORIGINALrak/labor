using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor8
{
    internal class Field
    {
        public Field(int meret)
        {
            Meret = meret;
        }

        public int Meret;
        public int TargetX { get { return Meret - 1; } }
        public int TargetY { get { return Meret - 1; } }

        public bool AllowedPosition(int x, int y)
        {
            if(x >= 0 && x < Meret && y >= 0 && y < Meret)
            {
                return false;
            }
            return true;
        }
        public void Show(int targetx, int targety)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(0, 0);
            for(int i = 0; i < Meret; i++)
            {
                for (int j = 0; j < TargetX; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }
    }
}
