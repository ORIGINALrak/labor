using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Team team = new Team();
            Player[] players = RandomPlayers(10);
            for(int i = 0; i < players.Length; i++)
            {
                team.Include(players[i]);
            }
        }
        static Player[] RandomPlayers(int num)
        {
            Random r = new Random();
            Player[] p = new Player[num];
            for (int i = 0; i < num; i++)
            {
                string name = ToolBox.NevGenerator();
                Position pos = (Position)r.Next(4);
                Player player = new Player(name, pos);
                p[i] = player;
            }
            return p;
        }
    }
}
