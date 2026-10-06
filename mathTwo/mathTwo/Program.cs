using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double Phi = (1 + Math.Sqrt(5)) / 2;

            int number = 2;

            Console.WriteLine(number);
            Console.WriteLine(number++);
            Console.WriteLine(number);
            Console.WriteLine(++number);
            Console.WriteLine(number++ + ++number);
            Console.WriteLine(number);

            number += 3;
            Console.WriteLine(number);
        }
    }
}
