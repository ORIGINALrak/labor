using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labor12
{
    public enum CatBreed { tabby, black, orange };
    internal class Program
    {
        static void Main(string[] args)
        {
            CrazyCatLady ccl = new CrazyCatLady("cats.csv");
            Console.WriteLine(ccl.AVGage(CatBreed.orange));
            Console.WriteLine(ccl.OldestCat());
            Console.WriteLine(ccl.OldestCat(CatBreed.orange));
            Cat[] cats = ccl.SelectCats(CatBreed.orange);
        }
    }
}
