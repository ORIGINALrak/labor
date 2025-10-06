using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Labor4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            #region 1. feladat
            //string szoveg = "asdsadwa3123poasdewqw waodka oapwjdapowdk awdawklapwd92ja28j378dahi 3a8";
            //int szamjegy = 0;
            //int betuk = 0;
            //int maganhangzok = 0;
            //string mgh = "aáeéiíoóöőuúüű";
            //for (int i = 0; i < szoveg.Length; i++)
            //{
            //    if (char.IsDigit(szoveg[i]))
            //    {
            //        szamjegy++;
            //    }
            //    if (char.IsLetter(szoveg[i]))
            //    {
            //        betuk++;
            //    }
            //    if (mgh.Contains(szoveg[i]))
            //    {
            //        maganhangzok++;
            //    }
            //}
            //Console.WriteLine(szoveg);
            //Console.WriteLine($"A szövegben a számok száma: {szamjegy}\n\t    a betük száma: {betuk}\n\t    a magánhangzók száma: {maganhangzok}");
            #endregion
            #region 3. feladat
            //string rendszam = "a a BC123";
            //string tisztitott = "";
            //for (int i = 0; i < rendszam.Length; i++)
            //{
            //    if (char.IsLetterOrDigit(rendszam[i]))
            //    {
            //        tisztitott += rendszam[i];
            //    }
            //}
            //tisztitott = tisztitott.ToUpper();
            //tisztitott = tisztitott.Insert(2, " ");
            //tisztitott = tisztitott.Insert(5, "-");
            //Console.WriteLine($"{tisztitott}");
            #endregion
            #region 4. feladat
            //string rendszam = "";
            //for (int i = 0; i < 4; i++)
            //{
            //    rendszam += (char)random.Next('A', 'Z' + 1);
            //}
            //rendszam = rendszam.Insert(2, " ");
            //rendszam += "-";
            //for (int i = 0; i < 3; i++)
            //{
            //    rendszam += (char)random.Next('0', '9' + 1);
            //}
            //Console.WriteLine($"Random rendszám: {rendszam}");
            #endregion
            #region 8. feladat
            //string szoveg = "Vincent;Vega;Vince\nMarsellus;Wallace;Big Man\nWinston;Wolf;The Wolf";
            //string[] felbontas = szoveg.Split('\n');
            //int sorszam = felbontas.Length;
            //int oszlopszam = felbontas[0].Split(';').Length;
            //string[,] matrix = new string[sorszam, oszlopszam];
            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    string[] felbontas2 = felbontas[i].Split(';');
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        matrix[i, j] = felbontas2[j];
            //    }
            //}
            //for (int i = 0;i < matrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        Console.Write(matrix[i, j] + " | ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region 2. 1. feladat
            //StreamReader sr = new StreamReader("beolvasas.txt");
            //while (!sr.EndOfStream)
            //{
            //    string adatok = sr.ReadLine();
            //    string[] strings1 = adatok.Split('#');
            //    if (strings1[0] == "Red")
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //    }
            //    else if (strings1[0] == "Green")
            //    {
            //        Console.ForegroundColor = ConsoleColor.Green;
            //    }
            //    else if (strings1[0] == "Blue")
            //    {
            //        Console.ForegroundColor = ConsoleColor.Blue;
            //    }
            //    Console.WriteLine(strings1[1]);
            //    Console.ResetColor();
            //}
            //sr.Close();

            #endregion
            #region 2. 4. feladat
            string[] Adatok = File.ReadAllLines("NHANES_1999-2018.csv");
            int[] SEQN = new int[Adatok.Length - 1];
            string[] SURVEY = new string[Adatok.Length - 1];
            double[] RIAGENDR = new double[Adatok.Length - 1];
            double[] RIDAGEYR = new double[Adatok.Length - 1];
            double[] BMXBMI = new double[Adatok.Length - 1];
            double[] LBDGLUSI = new double[Adatok.Length - 1];
            for(int i = 0; i < Adatok.Length - 1; i++)
            {
                string[] felbontas = Adatok[i + 1].Split(',');
                SEQN[i] = int.Parse(felbontas[0]);
                SURVEY[i] = felbontas[1];
                RIAGENDR[i] = double.Parse(felbontas[2]);
                RIDAGEYR[i] = double.Parse(felbontas[3]);
                BMXBMI[i] = double.Parse(felbontas[4]);
                LBDGLUSI[i] = double.Parse(felbontas[5]);
            }
            double fatlag = 0;
            double natlag = 0;
            int fdb = 0;
            int ndb = 0;
            for (int i = 0; i < RIAGENDR.Length; i++)
            {
                if (RIAGENDR[i] == 1.0)
                {
                    fatlag += BMXBMI[i];
                    fdb++;
                }
                if (RIAGENDR[i] == 2.0)
                {
                    natlag += BMXBMI[i];
                    ndb++;
                }
            }
            fatlag = fatlag / fdb;
            natlag = natlag / fdb;
            Console.WriteLine(fatlag + " " + natlag);
            

            double vercukor = 0;
            for(int i = 0;i < LBDGLUSI.Length; i++)
            {
                if (LBDGLUSI[i] > 5.6)
                {
                    vercukor++;
                }
            }
            double szazalek = vercukor / SEQN.Length * 100;
            Console.WriteLine(szazalek);


            int maxi = 0;
            double max = 0;
            for( int i = 0; i < BMXBMI.Length ; i++)
            {
                if (BMXBMI[i] > max)
                {
                    max = BMXBMI[i];
                    maxi = i;
                }
            }
            Console.WriteLine(LBDGLUSI[maxi]);


            double tulavg = 0;
            int tuldb = 0;
            for(int i = 0;i < BMXBMI.Length; i++)
            {
                if (BMXBMI[i] >= 30)
                {
                    tulavg += RIDAGEYR[i];
                    tuldb++;
                }
            }
            double atlageletkor = tulavg / tuldb;
            Console.WriteLine(atlageletkor);
            #endregion
        }
    }
}
