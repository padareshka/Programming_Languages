using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm8Exer1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());

            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                    sum -= 1.0 / i;
                else
                    sum += 1.0 / i;
            }

            Console.WriteLine("Сумма = " + sum);
        }
    }
}
