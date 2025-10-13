using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor_6
{
    internal class Book
    {
        public Book(string szerzo, string cim, int kiadev, int oldal)
        {
            Szerzo=szerzo;
            Cim=cim;
            Kiadev=kiadev;
            Oldal=oldal;
        }

        string Szerzo { get; set; }
        string Cim { get; set; }
        int Kiadev { get; set; }
        int Oldal { get; set; }

        public string AllData()
        {
            return Szerzo + ": " + Cim + ", " + Kiadev + " ("+ Oldal +")";
        }
    }
}
