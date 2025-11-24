using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labor12
{
  
    internal class Cat
    {
        string name;
        public string Name { get { return name; } }

        int age;
        public int Age { get { return age; } set { if (value >= 0) { age = value; } else { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Ilyet itt nem lehet csinálni"); } } }

        CatBreed breed;
        public CatBreed Breed { get { return breed; } }

        public Cat(string name, int age, CatBreed breed)
        {
            this.name = name;
            Age = age;
            this.breed = breed;
        }


        public string AllData()
        {
            return name + " (" + breed + "): " + age + " years old";
        }
    }
}
