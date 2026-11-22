using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm8Exer2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Введите a0: ");
            double previous = double.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Введите a" + i + ": ");
                double current = double.Parse(Console.ReadLine());

                Console.WriteLine(previous * current);

                previous = current;
            }
        }
    }
}