using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace labor3_lista_tomb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            #region pakli generálás
            List<string> pakli = new List<string>();
            string[] szinek = new string[4] { "Kör", "Káró", "Treff", "Pikk" };
            string[] face = new string[4] { "Jumbó", "Dáma", "Király", "Ász" };
            for (int j = 0; j < szinek.Length; j++)
            {
                for (int i = 2; i <= 11; i++)
                {
                    if (i <= 10)
                    {
                        pakli.Add(szinek[j] + " " + i);
                    }
                    else
                    {
                        for (int k = 0; k < face.Length; k++)
                        {
                            pakli.Add(szinek[j] + " " + face[k]);
                        }
                    }
                }
            }
            //for (int i = 0; i < pakli.Count; i++)
            //{
            //    Console.WriteLine(pakli[i]);
            //}
            #endregion
            #region keverés
            for (int i = 0; i < pakli.Count - 1; i++)
            {
                int j = random.Next(pakli.Count - 1);
                string k = pakli[j];
                pakli[j] = pakli[i];
                pakli[i] = k;
            }

            //for (int i = 0; i < pakli.Count; i++)
            //{
            //    Console.WriteLine(pakli[i]);
            //}
            #endregion
            #region dbszó
            //string[] szavak = new string[5];
            //Console.WriteLine("Írj be 4 darab szót:");
            //szavak[0] = Console.ReadLine();
            //szavak[1] = Console.ReadLine();
            //szavak[2] = Console.ReadLine();
            //szavak[3] = Console.ReadLine();
            //Console.WriteLine("Most írj még egyet:");
            //string tovabbiszo = Console.ReadLine();
            //int p = 0;
            //while (p < szavak.Length && szavak[p] != tovabbiszo)
            //{
            //    p++;
            //}
            //if (p < szavak.Length) { Console.WriteLine($"A szó benne van a gyüjteményben, a {p+1}. helyen!"); }
            //else
            //{
            //    Console.WriteLine("A szó nincs benne a gyüjteményben");
            //}
            #endregion
            #region felmérés
            //List<string> nevek = new List<string>();
            //List<int> eletkorok = new List<int>();
            //List<bool> tapasztalatok = new List<bool>();
            //string nev;
            //do
            //{
            //    Console.Write("Kérem a nevét: ");
            //    nev = Console.ReadLine();
            //    if (nev != "")
            //    {
            //        nevek.Add(nev);
            //        Console.Write("Életkor: ");
            //        eletkorok.Add(int.Parse(Console.ReadLine()));
            //        Console.Write("Tapasztalat [true/false]: ");
            //        tapasztalatok.Add(bool.Parse(Console.ReadLine()));
            //    }
            //}
            //while (nev != "");
            //int sum = 0;
            //foreach (int item in eletkorok) 
            //{
            //    sum += item;
            //}
            //if (eletkorok.Count > 0)
            //{
            //    Console.WriteLine("Az átlagéletkor: " + sum / (double)eletkorok.Count);
            //}
            //sum = 0;
            //int db = 0;
            //for (int i = 0; i < eletkorok.Count; i++)
            //{
            //    if (tapasztalatok[i] == false)
            //    {
            //        sum += eletkorok[i];
            //        db++;
            //    }
            //}
            //if(db > 0)
            //{
            //    Console.WriteLine("A programozói tapasztalat nélküli személyek átlagéletkora: " + sum / (double)db);
            //}
            //else
            //{
            //    Console.WriteLine("Nincs ilyen személy!");
            //}
            //int max = int.MinValue;
            //int maxi = -1;
            //for (int i = 0; i < eletkorok.Count; i++)
            //{
            //    if (tapasztalatok[i] == true)
            //    {
            //        if(max < eletkorok[i])
            //        {
            //            maxi = i;
            //            max = eletkorok[i];
            //        }
            //    }
            //}
            //if(maxi == -1)
            //{
            //    Console.WriteLine("Nincs ilyen személy");
            //}
            //else
            //{
            //    Console.WriteLine($"A legidősebb programozói tapasztalattal rendelkező személy neve, életkora\n\t{nevek[maxi]}\n\t{eletkorok[maxi]}");
            //}
            #endregion
            #region mátrix
            //int N = 5;
            //int M = 6;
            //int[,] matrix = new int[N, M];
            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        matrix[i, j] = random.Next(0, 10);
            //    }
            //}
            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        Console.Write(matrix[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //int[,] matrixTr = new int[matrix.GetLength(1), matrix.GetLength(0)];
            //for (int i = 0;i < matrix.GetLength(0); i++)
            //{
            //    for ( int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        matrixTr[j, i] = matrix[i, j];
            //    }
            //}
            //Console.WriteLine();
            //for (int i = 0; i < matrixTr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrixTr.GetLength(1); j++)
            //    {
            //        Console.Write(matrixTr[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region 8. feladat
            Console.Write("Kérek egy N pozitiv egész értéket: ");
            int N8 = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            list.Add(N8);
            int K;
            do
            {
                K = list.Last();
                if (K > 1)
                {
                    if (K % 2 == 0)
                    {
                        list.Add(K / 2);
                    }
                    else
                    {
                        list.Add(3 * K + 1);
                    }
                }
            }
            while (K > 1);
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            #endregion
        }
    }
}
