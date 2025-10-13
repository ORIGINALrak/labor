using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor_6
{
    internal class Teglalap
    {
        int szelesseg;
        int magassag;
        ConsoleColor szin;

        public Teglalap(int szelesseg, int magassag, ConsoleColor szin)
        {
            this.szelesseg=szelesseg;
            this.magassag=magassag;
            this.szin=szin;
        }
        private double Area()
        {
            return szelesseg * magassag;
        }
        public bool IsValid()
        {
            return Area() > 0;
        }
    }
}
