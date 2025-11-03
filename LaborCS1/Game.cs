using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LaborCS
{
    internal class Game
    {
        public Game()
        {
            Player = new Player(0, 0);
            Exited = false;
        }

        public Player Player { get; set; }
        public bool Exited { get; set; }

        private void RenderSingleSprite(Position p, ConsoleSprite cs)
        {
            if (Console.WindowWidth > p.X && Console.WindowHeight > p.Y && p.X >= 0 && p.Y >= 0)
            {
                Console.SetCursorPosition(p.X, p.Y);
                Console.BackgroundColor = cs.Background;
                Console.ForegroundColor = cs.Foreground;
                Console.Write(cs.Glyph);
                Console.ResetColor();
            }
        }
        private void RenderGame()
        {
            Console.CursorVisible = false;
            Console.ResetColor();
            Console.Clear();
            RenderSingleSprite(Player.Pos, Player.Sprite);
        }
        private void UserAction()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressed = Console.ReadKey(true);
                switch (pressed.Key)
                {
                    case ConsoleKey.Escape:
                        Exited = true;
                        break;
                    case ConsoleKey.UpArrow:
                        if(Player.Pos.X > 0)
                        {
                            Player.Pos.X--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (Player.Pos.X <= Console.WindowHeight - 1)
                        {
                            Player.Pos.X++;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (Player.Pos.Y > 0)
                        {
                            Player.Pos.Y--;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (Player.Pos.Y <= Console.WindowWidth - 1)
                        {
                            Player.Pos.Y++;
                        }
                        break;
                }
            }
        }
        public void Run()
        {
            do
            {
                RenderGame();
                UserAction();
                Thread.Sleep(25);
            } while (!Exited);
        }
    }
}
