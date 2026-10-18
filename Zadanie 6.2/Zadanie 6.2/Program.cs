using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "прогулка";

            string word1 = "" + word[3] + word[2] + word[1] + word[6] + word[7];

            string word2 = "" + word[0] + word[2] + word[1] + word[2] + word[3];

            Console.WriteLine(word1);
            Console.WriteLine(word2);
        }
    }
}
