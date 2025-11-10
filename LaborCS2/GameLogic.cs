using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaborCS
{
    internal class GameLogic
    {
        Random rnd = new Random();
        public GameLogic(Game g)
        {
            Game = g;
        }

        public Game Game { get; }

        private void CleanUpGameItems()
        {
            List<GameItem> deletelist = new List<GameItem>();
            foreach (GameItem item in Game.gameitems)
            {
                if (item.Available == false)
                {
                    deletelist.Add(item);
                }
            }
            foreach (GameItem item in deletelist)
            {
                Game.gameitems.Remove(item);
            }
            deletelist.Clear();
        }
        private void CleanUpDemons()
        {
            List<Demon> deletelist = new List<Demon>();
            foreach (Demon demon in Game.demons)
            {
                if (demon.Alive == false)
                {
                    deletelist.Add(demon);
                }
            }
            foreach (Demon demon in deletelist)
            {
                Game.demons.Remove(demon);
            }
            deletelist.Clear();
        }
        private void DemonMoveLogic(Demon d)
        {

            if (d.State == DemonStateType.Idle)
            {
                int x = d.Pos.X + rnd.Next(-1, 2);
                int y = d.Pos.Y + rnd.Next(-1, 2);
                Position targetPosition = new Position(x, y);
                Move(d, targetPosition);
            }
        }
        private void DemonAttackLogic(Demon d)
        {
            double dist = Position.Distance(Game.Player.Pos, d.Pos);
            int U = 0;
            if (d.Type == DemonType.Zombieman)
            {
                U = rnd.Next(3, 15);
            }
            if (d.Type == DemonType.Imp)
            {
                U = rnd.Next(3, 24);
            }
            if (d.Type == DemonType.Mancubus)
            {
                U = rnd.Next(8, 64);
            }
            int dmg = (2 * U) / (1 + (int)dist);
            Game.Player.TakeDamage(dmg);
        }
        public List<GameItem> GetGameItemsWithinDistance(Position Pos, double distance)
        {
            List<GameItem> nearbyItems = new List<GameItem>();
            foreach (GameItem item in Game.gameitems)
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
            foreach (Demon demon in Game.demons)
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
            foreach (Demon demon in Game.demons)
            {
                totalFillingRatio += demon.FillingRatio;
            }
            return totalFillingRatio;
        }
        public void Move(Player p, Position Pos)
        {
            double totalFillingRatio = GetTotalFillingRatio(Pos);
            if (totalFillingRatio + p.FillingRatio <= 1.0)
            {
                p.Pos = Pos;
            }
        }
        public void Move(Demon d, Position Pos)
        {
            double totalFillingRatio = GetTotalFillingRatio(Pos);
            if (totalFillingRatio + d.FillingRatio <= 1.0)
            {
                d.Pos = Pos;
            }
        }
        public void PlayerAttackLogic(Player p)
        {
            List<Demon> nearbyDemons = GetDemonsWithinDistance(p.Pos, p.SightRange);
            if (p.Ammo > 0)
            {
                foreach (Demon d in nearbyDemons)
                {
                    double dist = Position.Distance(p.Pos, d.Pos);
                    int U = rnd.Next(35, 106);
                    int dmg = (2 * U) / (1 + (int)dist);
                    d.TakeDamage(dmg);
                    if (d.Alive == false)
                    {
                        if (d.Type == DemonType.Zombieman)
                        {
                            p.AddCombatPoints(1);
                        }
                        if (d.Type == DemonType.Imp)
                        {
                            p.AddCombatPoints(3);
                        }
                        if (d.Type == DemonType.Mancubus)
                        {
                            p.AddCombatPoints(10);
                        }
                    }
                }
            }
        }
        private void UpdateDemons()
        {
            foreach (Demon demon in Game.demons)
            {
                demon.UpdateState(Game.Player);
                if (demon.State == DemonStateType.Move)
                {
                    DemonMoveLogic(demon);
                }
            }
        }
        public void PlayerDirectInteractionLogic()
        {
            List<GameItem> items = GetGameItemsWithinDistance(Game.Player.Pos, 1.0);
            foreach(GameItem item in items)
            {
                if(item.Type == ItemType.Door)
                {
                    item.Interact();
                }
                if(item.Type == ItemType.LevelExit)
                {
                    Game.Exited = true;
                }
            }
        }
        public void UpdateGameState()
        {
            UpdateDemons();
            CleanUpGameItems();
            CleanUpDemons();
        }
    }
}
