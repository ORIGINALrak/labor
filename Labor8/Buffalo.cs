using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor8
{
    internal class Buffalo
    {
        int x;
        int y;
        public bool allapot;
        public int X { get { return x; } }
        public int Y { get { return y; } }

        static Random rnd = new Random();

        public Buffalo()
        {
            allapot = true;
        }
        public void Move(Field f)
        {
            int merre, ujX, ujY;
            do
            {
                merre = rnd.Next(3);
                ujX = x;
                ujY = y;

                if(merre == 0)
                {
                    ujX++;
                }
                else if(merre == 1)
                {
                    ujY++;
                }
                else
                {
                    ujX++;
                    ujY++;
                }
            } while (!f.AllowedPosition(ujX, ujY));
            x = ujX;
            y = ujY;
        }
        public void Deactivate()
        {
            allapot = false;
        }
        public void Show()
        {
            Console.SetCursorPosition(y, x);
            switch (allapot)
            {
                case true:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
            }
            Console.Write("B");
            Console.ResetColor();
        }
    }
}
