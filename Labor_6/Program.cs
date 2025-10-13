using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Labor_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Book b = new Book("Tolkien","Gyűrű Kúra", 1937, 312);
            //Console.WriteLine(b);
            //Console.WriteLine(b.AllData());

            //Book b2 = new Book(szerzo:"Tolkien", cim:"Gyűrű Kúra", kiadev:1937, oldal:312);
            //Console.WriteLine(b);
            //Console.WriteLine(b.AllData());


            //Runner r1 = new Runner("a", 2, 1);
            //Runner r2 = new Runner("b", 3, 2);

            //int delay = 1;
            //int celvonal = 15;

            //while(r1.GetDistance() < celvonal && r2.GetDistance() < celvonal)
            //{
            //    Console.Clear();
            //    r1.RefreshDistance(delay);
            //    r2.RefreshDistance(delay);
            //    r1.Show();
            //    r2.Show();
            //    Thread.Sleep(delay*1000);
            //}

            Kodolo k = new Kodolo(3);
            Console.WriteLine(k.Encode("Random üzenet"));
            Console.WriteLine(k.Decode("Udqgrp#ÿ}hqhw"));
        }
    }
}
