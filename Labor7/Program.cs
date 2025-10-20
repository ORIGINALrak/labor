using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Labor7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1. feladat
            //Mole m = new Mole();
            //Random random = new Random();
            //int size = random.Next(5, 50);
            //int beolvas = -1;
            //while (beolvas != m.Position)
            //{
            //    Console.Clear();
            //    m.Hide(0, size);
            //    Console.Clear();
            //    Console.Write($"Kérem a tippet (0-{size})");
            //    beolvas = int.Parse( Console.ReadLine() );

            //    m.TurnUp();
            //    Thread.Sleep(1000);
            //    Console.SetCursorPosition( beolvas, 0 );
            //    Console.Write('H');
            //    Console.SetCursorPosition(0, 0);
            //    Thread.Sleep(1000);
            //}
            #endregion
            #region 2. feladat

            GroundControl groundcontrol = new GroundControl();
            Flight fl0 = new Flight("LH1337", "BUD", new DateTime(2024, 10, 20, 11, 50, 10));
            groundcontrol.AddFlight(fl0);
            groundcontrol.DisplayFlightData();
            Console.WriteLine();
            fl0.Delay(30);
            groundcontrol.DisplayFlightData();
            #endregion
        }
    }
}
