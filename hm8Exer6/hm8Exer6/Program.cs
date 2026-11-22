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
            Console.Write("Введите m: ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());

            double sum = 0;

            for (int i = 1; i <= m; i++)
            {
                double power = 1;

                for (int j = 1; j <= n; j++)
                {
                    power *= i;
                }

                sum += power;
            }

            Console.WriteLine("Сумма = " + sum);
        }
    }
}