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
            Items = new List<GameItem>();
            Demons = new List<Demon>();
            player = new Player(0, 0);
            Exited = false;
        }
        List<Demon> Demons;
        List<GameItem> Items;
        public List<Demon> demons { get { return Demons; }  }
        public List<GameItem> gameitems { get { return Items; } }
        Player player;
        public Player Player { get { return player; } }
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
            foreach (GameItem item in Items)
            {
                RenderSingleSprite(item.Position, item.Sprite);
            }
            foreach (Demon demon in Demons)
            {
                RenderSingleSprite(demon.Pos, demon.Sprite);
            }
            RenderSingleSprite(player.Pos, player.Sprite);
        }
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
                }
                if (newX >= 0 && newX < Console.WindowWidth && newY >= 0 && newY < Console.WindowHeight - 1)
                    {
                        Move(this.Player, new Position(newX, newY));
                    }
                }
            }
        
        public void Run()
        {
            do
            {
                RenderGame();
                UserAction();
                CleanUpGameItems();
                Thread.Sleep(25);
            } while (!Exited);
        }
        private void CleanUpGameItems()
        {
            List<GameItem> deletelist = new List<GameItem>();
            foreach (GameItem item in Items)
            {
                if(item.Available == false)
                {
                    deletelist.Add(item);
                }
            }
            foreach (GameItem item in deletelist)
            {
                Items.Remove(item);
            }
            deletelist.Clear();
        }
        private void CleanUpDemons()
        {
            List<Demon> deletelist = new List<Demon>();
            foreach (Demon demon in Demons)
            {
                if (demon.Alive == false)
                {
                    deletelist.Add(demon);
                }
            }
            foreach (Demon demon in deletelist)
            {
                deletelist.Remove(demon);
            }
            deletelist.Clear();
        }
        public List<GameItem> GetGameItemsWithinDistance(Position Pos, double distance)
        {
            List<GameItem> nearbyItems = new List<GameItem>();
            foreach (GameItem item in Items)
            {
                double dist = Position.Distance(Pos, item.Position);
                if (dist <= distance)
                {
                    nearbyItems.Add(item);
                }
            }
            return nearbyItems;
        }
        private List<Demon> GetDemonsWithinDistance(Position Pos, double distance)
        {
            List<Demon> nearbyDemons = new List<Demon>();
            foreach (Demon demon in Demons)
            {
                double dist = Position.Distance(Pos, demon.Pos);
                if (dist <= distance)
                {
                    nearbyDemons.Add(demon);
                }
            }
            return nearbyDemons;
        }
        private double GetTotalFillingRatio(Position Pos)
        {
            List<GameItem> items = GetGameItemsWithinDistance(Pos, 0.0);
            double totalFillingRatio = 0.0;
            foreach (GameItem item in items)
            {
                totalFillingRatio += item.FillingRatio;
            }
            foreach (Demon demon in Demons)
            {
                totalFillingRatio += demon.FillingRatio;
            }
            return totalFillingRatio;
        }
        private void Move(Player p, Position Pos)
        {
            double totalFillingRatio = GetTotalFillingRatio(Pos);
            if (totalFillingRatio + p.FillingRatio <= 1.0)
            {
                p.Pos = Pos;
            }
        }
        private void Move(Demon d, Position Pos)
        {
            double totalFillingRatio = GetTotalFillingRatio(Pos);
            if (totalFillingRatio + d.FillingRatio <= 1.0)
            {
                d.Pos = Pos;
            }
        }
    }
}
