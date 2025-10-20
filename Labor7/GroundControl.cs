using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor7
{
    internal class GroundControl
    {
        public DateTime aktualisIdopont;
        List<Flight> jaratok;

        public GroundControl()
        {
            aktualisIdopont = DateTime.Now;
        }
        public void AddFlight(Flight f)
        {
            jaratok.Add(f);
        }
        private double AverageDelay()
        {
            double szum = 0;
            int db = 0;
            foreach (Flight f in jaratok)
            {
                if(f.Statusz != StatuszTipus.Canceled)
                {
                    szum += f.keses;
                    db++;
                }
            }
            if (db > 0)
            {
                return szum / db;
            }
            return 0;
        }
        public void DisplayFlightData()
        {
            foreach (Flight f in jaratok)
            {
                Console.WriteLine(f.AllData());
            }
            Console.WriteLine($"Átlagos késés: " + AverageDelay());
        }
    }
}
