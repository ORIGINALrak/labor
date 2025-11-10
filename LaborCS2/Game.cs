using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LaborCS
{
    internal class Game
    {
        Random rnd = new Random();
        public Game()
        {
            Items = new List<GameItem>();
            Demons = new List<Demon>();
            player = new Player(0, 0);
            Exited = false;
            Renderer = new ConsoleRenderer(this);
        }
        List<Demon> Demons;
        public List<Demon> demons { get { return Demons; }  }
        List<GameItem> Items;
        public List<GameItem> gameitems { get { return Items; } }
        Player player;
        public Player Player { get { return player; } }
        public bool Exited { get; set; }
        public ConsoleRenderer Renderer { get; }
        public GameLogic Logic { get; }
        public Stopwatch StopwatchLogic { get;  }
        public Stopwatch StopwatchRenderer { get;  }
        private void UserAction()
        {
            
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressed = Console.ReadKey(true);
                int newX = this.Player.Pos.X;
                int newY = this.Player.Pos.Y;

                switch (pressed.Key)
                {
                    case ConsoleKey.Escape:
                        Exited = true;
                        break;
                    case ConsoleKey.UpArrow:
                            newY--;
                        break;
                    case ConsoleKey.DownArrow:
                            newY++;
                        break;
                    case ConsoleKey.LeftArrow:
                            newX--;
                        break;
                    case ConsoleKey.RightArrow:
                            newX++;
                        break;
                    case ConsoleKey.D:
                        foreach (GameItem item in Items)
                        {
                            item.Interact();
                        }
                        break;
                    case ConsoleKey.A:
                        Logic.PlayerAttackLogic(player);
                        break;
                }
                if (newX >= 0 && newX < Console.WindowWidth && newY >= 0 && newY < Console.WindowHeight - 1)
                    {
                        Logic.Move(this.Player, new Position(newX, newY));
                    }
                }
            }
        public void Run()
        {
            do
            {
                StopwatchRenderer.Start();
                StopwatchLogic.Start();
                if (StopwatchLogic.ElapsedMilliseconds > 500)
                {
                    Logic.UpdateGameState();
                    StopwatchLogic.Restart();
                }
                if (StopwatchRenderer.ElapsedMilliseconds > 25)
                {
                    Renderer.RenderGame();
                    StopwatchRenderer.Restart();
                }
                UserAction();
                Thread.Sleep(25);
            } while (!Exited && player.Alive == false);
        }
    }
}
