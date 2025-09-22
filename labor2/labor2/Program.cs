using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace labor2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Random random = new Random();
            #region Feladat1
            //int number;
            //Console.Write("Írjon be egy egész számot: ");
            //number = Convert.ToInt16(Console.ReadLine());
            //while (number > 1)
            //{
            //    number--;
            //    if(number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}
            #endregion
            #region Feladat2
            //int tries = 3;

            //string password = "jelszo123";
            //string enteredPassword = "";
            //while (tries > 0 && password != enteredPassword)
            //{

            //    Console.Write("Írja be a jelszavát: ");
            //    enteredPassword = Console.ReadLine();
            //    if (password == enteredPassword)
            //    {
            //        Console.WriteLine("Sikerült bejelentkezni!");
            //    }
            //    else
            //    {
            //        tries--;
            //    }
            //}
            //if(tries == 0)
            //{
            //    Console.WriteLine("Nem sikerült bejelentkezni!");
            //}
            #endregion
            #region Feladat3
            //Console.Write("Írjon be egy számot 1 és 1000 között: ");
            //int innumber = Convert.ToInt16(Console.ReadLine());
            //random = new Random();
            //int count = 0;
            //int randomnumber = 0;
            //do
            //{
            //    randomnumber = random.Next(1, 1001);
            //    count++;
            //}
            //while (randomnumber != innumber);
            //Console.WriteLine($"Ennyi próbálkozás kellett hozzá: {count}");
            #endregion
            #region Feladat4
            //Console.WriteLine("Adja meg hány játékos játszik: ");
            //int playerCount = Convert.ToInt16(Console.ReadLine());
            //int countedPlayers = 0;
            //random = new Random();
            //int rolledNumber = 0;
            //while (rolledNumber != 6)
            //{
            //    Console.Write($"nyomja meg a {countedPlayers + 1}. játékos az entert a dobáshoz!");
            //    Console.ReadLine();
            //    rolledNumber = random.Next(1, 7);
            //    Console.WriteLine(rolledNumber);
            //    if (rolledNumber == 6)
            //    {
            //        Console.WriteLine("Hatost dobtál, te kezdesz");
            //    }
            //    countedPlayers++;
            //    if (countedPlayers == playerCount)
            //    {
            //        countedPlayers = 0;
            //    }
            //}
            #endregion
            #region Feladat5
            //random = new Random();
            //int imaginedNumber = random.Next(1, 101);
            //int inNumber = 101;
            //int imaginetries = 0;
            //while (imaginedNumber != inNumber)
            //{
            //    imaginetries++;
            //    Console.Write("Adja meg, hogy hányas számra gondoltam: ");
            //    inNumber = Convert.ToInt16(Console.ReadLine());
            //    if (imaginedNumber > inNumber)
            //    {
            //        Console.WriteLine("A gondolt szám nagyobb");
            //    }
            //    else if (imaginedNumber < inNumber)
            //    {
            //        Console.WriteLine("A gondolt szám kisebb");
            //    }
            //}
            //Console.Write($"Igen, a {imaginedNumber}-re gondoltam\t");
            //Console.WriteLine($"Ennyi próbálkozásból: {imaginetries}");
            #endregion
            #region Feladat6
            //Console.WriteLine("Adjon meg egy pozitív egész számot");
            //int nNumber = Convert.ToInt16(Console.ReadLine());
            //int OGnNumber = nNumber;
            //if (nNumber % 2 == 0)
            //{
            //    Console.WriteLine("A szám páros");
            //}
            //else
            //{
            //    Console.WriteLine("A szám páratlan!");
            //}
            //List<int> dividers = new List<int>();
            //while (nNumber != 0)
            //{

            //    if (OGnNumber % nNumber == 0)
            //    {
            //        dividers.Add(nNumber);
            //    }
            //    nNumber--;
            //}
            //Console.WriteLine("Pozitív osztóinak száma:");
            //foreach (int i in dividers)
            //{
            //    Console.Write($"{i} ");
            //}
            //if (dividers.Count == 2)
            //{
            //    Console.WriteLine("\nA számod prím szám");
            //}
            //else
            //{
            //    Console.WriteLine("\nA számod összetett szám");
            //}
            #endregion
            #region Feladat7
            //Console.WriteLine("Írjon be egy pozitív egész számot: ");
            //int fNumber = Convert.ToInt16(Console.ReadLine());
            //List<int> numberlist = new List<int>();
            //int endNumber = 1;
            //while (fNumber != 0)
            //{
            //    numberlist.Add(fNumber);
            //    fNumber--;
            //}
            //foreach (int i in numberlist)
            //{
            //     endNumber = endNumber * i;
            //}
            //Console.WriteLine($"A számod faktoriálisa: {endNumber}");
            #endregion
            #region Feladat8
            //int cols = 1;
            //int rows = 1;
            //int number = 0;
            //while (number != 81)
            //{
            //    number = cols * rows;
            //    Console.Write($"{number}\t");
            //    rows++;
            //    if(rows == 10)
            //    {
            //        Console.WriteLine();
            //        rows = 1;
            //        cols++;
            //    }
            //}
            #endregion
            #region Feladat9
            //Console.Write("Add meg hogy mennyit szeretnél várni (másodpercben): ");
            //int seconds = Convert.ToInt16(Console.ReadLine());
            //while (seconds > 0)
            //{
            //    Console.Clear();
            //    int minutes = seconds / 60;
            //    int second = seconds % 60;
            //    Console.WriteLine($"Ennyi másodperc van még hátra: {minutes}:{second}");
            //    System.Threading.Thread.Sleep(1000); seconds--;
            //}
            //Console.BackgroundColor = ConsoleColor.Red;
            //Console.Clear();
            #endregion
            #region Feladat10

            #endregion
            #region Feladat 11
            Console.WriteLine("Ez egy félkaru rabló!");
            int credit = 100;
            int bet = 1;
            random = new Random();
            int symbol1 = 0;
            int symbol2 = 0;
            int symbol3 = 0;
            ConsoleKeyInfo gomb;
            do
            {
                Console.Clear();
                Console.WriteLine($"{symbol1} {symbol2} {symbol3}");
                Console.WriteLine($"Kreditek: {credit}, Tét: {bet}");
                gomb = Console.ReadKey();
            } while (gomb.Key != ConsoleKey.Escape && credit >0);
            #endregion
        }
    }
}
