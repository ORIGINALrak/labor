using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor8
{
    internal class Team
    {

        Player[] players;
        public int NumberOfPlayers { get; private set; }
        public bool IsFull { get { return NumberOfPlayers == players.Length; } }

        public bool IsIncluded(Player player)
        {
            foreach(Player p in players)
            {
                if (p.Equals(player))
                {
                    return true;
                }
            }
            return false;
        }

        public Team()
        {
            players = new Player[5];
            NumberOfPlayers = 0;
        }
        public bool IsAvailable(Player player)
        {
            if (player.Pozicio == Position.Winger)
            {
                int db = 0;
                foreach(Player p in players)
                {
                    if (p.Pozicio.Equals(player.Pozicio))
                    {
                        db++;
                    }
                }
                if (db == 2)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                foreach (Player p in players)
                {
                    if (p.Pozicio.Equals(player.Pozicio))
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        public void Include(Player player)
        {
            if(!IsIncluded(player) && IsAvailable(player))
            {
                players[NumberOfPlayers++] = player;
            }
            else
            {
                Console.WriteLine("Nem került új játékos a csapatba");
            }
        }
    }
}
