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
            filling = 0.4;
            health = 100;
            sight = 8;
            alive = true;
            ammo = 30;
        }
        Position playerPos;
        public Position Pos { get { return playerPos; } set { playerPos = value; } }
        ConsoleSprite sprite;
        public ConsoleSprite Sprite { get { return sprite; } set; }
        double filling;
        public double FillingRatio { get { return filling; } }
        int health;
        public int Health { get { return health; } }
        int ammo;
        public int Ammo { get { return ammo; } }
        bool alive;
        public bool Alive { get { return alive; } }
        int combatpoint;
        public int CombatPoints { get { return combatpoint; } }
        public int MaxHealth { get; set { MaxHealth = 100 + (CombatPoints / 10); } }
        public int MaxAmmo { get; set { MaxAmmo = 100 + (CombatPoints / 10); } }
        int sight;
        public int SightRange { get { return sight; } }


        public void Shoot()
        {
            if (ammo>0)
            {
                ammo -= 1;
            }
        }
        public void AddCombatPoints(int cp)
        {
            combatpoint += cp;
        }
        public void TakeDamage(int damage)
        {
            if (health > 0)
            {
                health -= damage;
            }
            if (health <= 0)
            {
                alive = false;
            }
        }
        public void PickUpAmmo(int a)
        {
            ammo += a;
            if(ammo <= MaxAmmo)
            {
                ammo = MaxAmmo;
            }
        }
    }
}
