using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaborCS
{
    enum ItemType { Ammo, BFGCell, Door, LevelExit, Medikit, ToxicWaste, Wall }
    internal class GameItem
    {
       
        Position itempos;
        ConsoleSprite itemsprite;
        ItemType itemtype;
        double filling;
        bool available;

        public GameItem(int x, int y, ItemType item)
        {
            itempos = new Position(x, y);
            itemtype = item;
            SetInitialProperties();
        }

        public Position Position { get { return itempos; } }
        public ConsoleSprite Sprite { get { return itemsprite; } }
        public ItemType Type { get { return itemtype; } }
        public double FillingRatio { get { return filling; } }
        public bool Available { get { return available; } }

        private void SetInitialProperties()
        {
            available = true;
            switch (itemtype)
            {
                case ItemType.Ammo:
                    {
                        filling = 0.0;
                        itemsprite = new ConsoleSprite(background:ConsoleColor.Red,foreground:ConsoleColor.Yellow,glyph:'A');
                        break;
                    }
                case ItemType.BFGCell:
                    {
                        filling = 0.0;
                        itemsprite = new ConsoleSprite(background: ConsoleColor.Green, foreground: ConsoleColor.White, glyph: 'B');
                        break;
                    }
                case ItemType.Door:
                    {
                        filling = 1.0;
                        if (filling == 1.0)
                        {
                            itemsprite = new ConsoleSprite(background: ConsoleColor.DarkGray, foreground: ConsoleColor.Yellow, glyph: '/');
                        }
                        else
                        {
                            itemsprite = new ConsoleSprite(background: ConsoleColor.DarkGray, foreground: ConsoleColor.DarkYellow, glyph: '/');
                        }
                        break;
                    }
                case ItemType.LevelExit:
                    {
                        filling = 0.0;
                        itemsprite = new ConsoleSprite(background: ConsoleColor.Cyan, foreground: ConsoleColor.Black, glyph: 'E');
                        break;
                    }
                case ItemType.Medikit:
                    {
                        filling = 0.0;
                        itemsprite = new ConsoleSprite(background: ConsoleColor.Gray, foreground: ConsoleColor.Red, glyph: '+');
                        break;
                    }
                case ItemType.ToxicWaste:
                    {
                        filling = 0.0;
                        itemsprite = new ConsoleSprite(background: ConsoleColor.DarkGreen, foreground: ConsoleColor.White, glyph: ':');
                        break;
                    }
                case ItemType.Wall:
                    {
                        filling = 0.0;
                        itemsprite = new ConsoleSprite(background: ConsoleColor.DarkGray, foreground: ConsoleColor.DarkGray, glyph: ' ');
                        break;
                    }
                
            }
        }
        public void Interact()
        {
            switch (itemtype)
            {
                case ItemType.Ammo:
                    {
                        available = false;
                        break;
                    }
                case ItemType.BFGCell:
                    {
                        available = false;
                        break;
                    }
                case ItemType.Medikit:
                    {
                        available = false;
                        break;
                    }
                case ItemType.Door:
                    {
                        if (filling == 0.0)
                        {
                            itemsprite = new ConsoleSprite(background: ConsoleColor.DarkGray, foreground: ConsoleColor.DarkYellow, glyph: '/');
                            filling = 1.0;
                        }
                        else
                        {
                            itemsprite = new ConsoleSprite(background: ConsoleColor.DarkGray, foreground: ConsoleColor.Yellow, glyph: '/');
                            filling = 0.0;
                        }
                        break;
                    }
            }
        }
    }
}
