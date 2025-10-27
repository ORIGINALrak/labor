using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Labor8
{
    public enum Position { Goalkeeper, Forward, Winger, Defender }
    internal class Player
    {
        public string Name { get; }
        public Position Pozicio { get; }

        public Player(string name, Position pozicio)
        {
            Name = name;
            Pozicio = pozicio;
        }
        public override string ToString()
        {
            return $"{this.Name} {this.Pozicio}";
        }
    }
}
