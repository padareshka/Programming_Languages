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
            Console.Write("Введите a (> 1): ");
            double a = double.Parse(Console.ReadLine());

            double sum = 0;
            int n = 1;

            while (true)
            {
                sum += 1.0 / n;

                if (sum < a)
                {
                    Console.WriteLine(n);
                    n++;
                }
                else
                {
                    break;
                }
            }
        }
    }
}