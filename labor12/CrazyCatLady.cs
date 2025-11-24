using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace labor12
{
    internal class CrazyCatLady
    {
        //public List<Cat> cats { get { return Cats; }  }

        List<Cat> Cats { get; }
        public int SumOfAge
        {
            get
            {
                int sum = 0;
                foreach (Cat cat in Cats)
                {
                    sum += cat.Age;
                }
                return sum;
            }
        }
        public CrazyCatLady(string filename)
        {
            Cats = new List<Cat>();
            string[] sorok = File.ReadAllLines(filename);
            for (int i = 1; i < sorok.Length; i++)
            {
                string[] sor = sorok[i].Split(',');
                string name = sor[0];
                int age = (DateTime.Today - DateTime.Parse(sor[1])).Days/365;
                CatBreed breed = (CatBreed)Enum.Parse(typeof(CatBreed), sor[2]); //puska material
                Cat cat = new Cat(name, age, breed);
                Cats.Add(cat);
            }
        }

        public Cat OldestCat()
        {
            int maxID = 0;
            for (int i = 0; i < Cats.Count; i++)
            {
                if (Cats[maxID].Age < Cats[i].Age)
                {
                    maxID = i;
                }
            }
            return Cats[maxID];
        }
        public Cat OldestCat(CatBreed breed)
        {
            int maxID = -1;
            int maxVal = int.MinValue;
            for(int i = 0;i < Cats.Count; i++)
            {
                if (Cats[i].Breed == breed)
                {
                    if (maxVal < Cats[i].Age)
                    {
                        maxID = i;
                        maxVal = Cats[i].Age;
                    }
                }
            }
            if(maxID == -1)
            {
                return null;
            }
            return Cats[maxID];
        }
        public double AVGage(CatBreed breed)
        {
            double sum = 0;
            int count = 0;
            foreach(Cat cat in Cats)
            {
                if(cat.Breed == breed)
                {
                    sum += cat.Age;
                    count++;
                }
            }
            return sum / count;
        }
        public Cat[] SelectCats(CatBreed breed)
        {
            Cat[] temp = new Cat[Cats.Count];
            int counter = 0;
            for(int i = 0; i < Cats.Count; i++)
            {
                if (Cats[i].Breed == breed)
                {
                    temp[counter] = Cats[i];
                    counter++;
                }
            }
            Cat[] results = new Cat[counter];
            for(int i = 0;i < counter; i++)
            {
                results[i] = temp[i];
         
            }
            return results;
        }
    }
}
