using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaborCS
{
    internal class ConsoleSprite
    {
        public ConsoleSprite(ConsoleColor background, ConsoleColor foreground, char glyph)
        {
            Background = background;
            Foreground = foreground;
            Glyph = glyph;
        }

        public ConsoleColor Background { get; }
        public ConsoleColor Foreground { get; }
        public char Glyph { get; }
    }
}
