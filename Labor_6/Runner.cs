using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor_6
{
    internal class Runner
    {
        string nev;
        int sorszam;
        int sebesseg;
        int tavolsag;

        public Runner(string nev, int sorszam, int sebesseg)
        {
            this.nev=nev;
            this.sorszam=sorszam;
            this.sebesseg=sebesseg;
            tavolsag = 0;
        }


        public void RefreshDistance(int s)
        {
            tavolsag += s * sebesseg;
        }

        public void Show()
        {
            Console.SetCursorPosition(tavolsag, sorszam);
            Console.Write(nev[0]);
        }
        public int GetDistance()
        {
            return tavolsag;
        }
    }
}
