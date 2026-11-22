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

            int min = 9;
            int max = 0;

            while (number > 0)
            {
                int digit = (int)(number % 10);

                if (digit > max)
                    max = digit;

                if (digit < min)
                    min = digit;

                number /= 10;
            }

            Console.WriteLine("Сумма = " + (min + max));
        }
    }
}
