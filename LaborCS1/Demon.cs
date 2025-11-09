using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LaborCS
{
    enum DemonType { Zombieman, Imp, Mancubus }
    enum DemonStateType { Idle, Move, Attack }
    internal class Demon
    {
        public Demon(int x, int y, DemonType t)
        {
            position.X = x; position.Y = y;
            type = t;
            alive = true;
            SetInitialProperties();
            state = DemonStateType.Idle;
        }
        Position position;
        public Position Pos { get { return position; } set { position = value; } }
        ConsoleSprite sprite;
        public ConsoleSprite Sprite { get { return sprite; } }
        DemonType type;
        public DemonType Type { get { return type; } }
        DemonStateType state;
        public DemonStateType State { get { return state; } }
        double filling;
        public double FillingRatio { get { return filling; } }
        int health;
        public int Health { get { return health; } set { if (health>0) { health = value; } } }
        bool alive;
        public bool Alive { get { return alive; } }
        int sightRange;
        public int SightRange { get { return sightRange; } }
        int attackRange;
        public int AttackRange { get { return attackRange; } }

        private void SetInitialProperties()
        {
            switch(type)
            {
                case DemonType.Zombieman:
                    {
                        filling = 0.4;
                        health = 20;
                        sightRange = 3;
                        attackRange = 1;
                        sprite = new ConsoleSprite(background: ConsoleColor.Black, foreground: ConsoleColor.White, glyph:'o');
                        break;
                    }
                case DemonType.Imp:
                    {
                        filling = 0.4;
                        health = 60;
                        sightRange = 6;
                        attackRange = 3;
                        sprite = new ConsoleSprite(background: ConsoleColor.Black, foreground: ConsoleColor.Red, glyph: 'o');
                        break;
                    }
                case DemonType.Mancubus:
                    {
                        filling = 0.96;
                        health = 600;
                        sightRange = 9;
                        attackRange = 6;
                        sprite = new ConsoleSprite(background: ConsoleColor.Black, foreground: ConsoleColor.Red, glyph: 'O');
                        break;
                    }
            }
        }
        public void UpdateState(Player p)
        {
            double dist = Position.Distance(Pos, p.Pos);
            if (dist < attackRange)
            {
                state = DemonStateType.Attack;
            }
            else if(dist < sightRange)
            {
                state = DemonStateType.Move;
            }
            else
            {
                state = DemonStateType.Idle;
            }
        }
    }
}
