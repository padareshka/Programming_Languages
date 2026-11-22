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
            Console.Write("Введите натуральное число: ");
            long number = long.Parse(Console.ReadLine());

            long maxDivisor = 1;
            long divisor = 2;

            while (divisor <= number / divisor)
            {
                if (number % divisor == 0)
                {
                    maxDivisor = divisor;

                    while (number % divisor == 0)
                    {
                        number /= divisor;
                    }
                }

                divisor++;
            }

            if (number > 1)
                maxDivisor = number;

            Console.WriteLine("Наибольший простой делитель = " + maxDivisor);
        }
    }
}