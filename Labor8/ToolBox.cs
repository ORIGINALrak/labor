using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Labor8 //<--- ezt ne felejtsük átírni a saját projektnevünkre!!!
{
    //felhasználás: string nev = ToolBox.NevGenerator();
    public static class ToolBox
    {
        static Random rnd = new Random();
        /// <summary>
        /// Egy random nevet generál a 100 leggyakoribb magyar vezeték és keresztnévből
        /// </summary>
        /// <returns></returns>
        public static string NevGenerator()
        {
            string[] csaladNevek = new string[] { "Nagy", "Kovács", "Tóth",
                "Szabó", "Horváth", "Varga", "Kiss", "Molnár", "Németh",
                "Farkas", "Balogh", "Papp", "Lakatos", "Takács", "Juhász",
                "Oláh", "Mészáros", "Simon", "Rácz", "Fekete", "Szilágyi",
                "Török", "Fehér", "Balázs", "Gál", "Kis", "Szűcs", "Orsós",
                "Kocsis", "Fodor", "Pintér", "Szalai", "Sipos", "Magyar",
                "Lukács", "Gulyás", "Biró", "Király", "Balog", "László",
                "Bogdán", "Jakab", "Katona", "Sándor", "Váradi", "Boros",
                "Fazekas", "Kelemen", "Antal", "Orosz", "Somogyi", "Fülöp",
                "Veres", "Budai", "Vincze", "Hegedűs", "Deák", "Pap", "Bálint",
                "Illés", "Pál", "Vass", "Szőke", "Fábián", "Vörös", "Lengyel",
                "Bognár", "Bodnár", "Jónás", "Szücs", "Hajdu", "Halász", "Máté",
                "Székely", "Gáspár", "Kozma", "Pásztor", "Bakos", "Dudás", "Virág",
                "Major", "Orbán", "Hegedüs", "Barna", "Novák", "Soós", "Tamás",
                "Nemes", "Pataki", "Balla", "Faragó", "Kerekes", "Barta", "Péter",
                "Borbély", "Csonka", "Mezei", "Sárközi", "Berki", "Márton" };
            string[] keresztNevek = new string[] { "Éva", "Mária", "Ildikó",
                "Katalin", "Erika", "Erzsébet", "Zsuzsanna", "Andrea", "Judit",
                "Ágnes", "Ilona", "Anikó", "Edit", "Gabriella", "Tünde", "Krisztina",
                "Márta", "Csilla", "Anna", "Gyöngyi", "Marianna", "Margit", "Julianna",
                "Ibolya", "Mónika", "Magdolna", "Irén", "Piroska", "Klára", "Tímea",
                "Hajnalka", "Szilvia", "Rita", "Eszter", "Valéria", "Veronika",
                "Györgyi", "Anita", "Rozália", "Enikő", "Aranka", "Gizella", "Edina",
                "Zita", "Angéla", "Emese", "Teréz", "Melinda", "Ágota", "Etelka",
                "László", "Zoltán", "István", "József", "János", "Attila", "Sándor",
                "Tibor", "Ferenc", "Zsolt", "Gábor", "Csaba", "Tamás", "Péter", "Imre",
                "György", "Lajos", "András", "Gyula", "Károly", "Béla", "Mihály", "Miklós",
                "Róbert", "Pál", "Antal", "Árpád", "Géza", "Kálmán", "Jenő", "Ernő", "Endre",
                "Ottó", "Balázs", "Ákos", "Dezső", "Nándor", "Vilmos", "Szabolcs", "Márton",
                "Levente", "Norbert", "Szilárd", "Barnabás", "Rudolf", "Bertalan", "Gusztáv",
                "Mátyás", "Ervin", "Győző" };

            return csaladNevek[rnd.Next(csaladNevek.Length)] + " " + keresztNevek[rnd.Next(keresztNevek.Length)];
        }
    }
}
