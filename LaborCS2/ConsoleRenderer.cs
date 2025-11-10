using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaborCS
{
    internal class ConsoleRenderer
    {
        public Game Game { get; }
        public ConsoleRenderer(Game g)
        {
            Game = g;
        }

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
        public void RenderGame()
        {
            Console.CursorVisible = false;
            Console.ResetColor();
            Console.Clear();
            foreach (GameItem item in Game.gameitems)
            {
                RenderSingleSprite(item.Position, item.Sprite);
            }
            foreach (Demon demon in Game.demons)
            {
                RenderSingleSprite(demon.Pos, demon.Sprite);
            }
            RenderSingleSprite(Game.Player.Pos, Game.Player.Sprite);
        }
    }
}
