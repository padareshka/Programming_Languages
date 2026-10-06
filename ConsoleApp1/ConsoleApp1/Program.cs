using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Введите четырехзначное число");
                int number = int.Parse(Console.ReadLine());

                int first = number / 1000;
                int second = number / 100 % 10;
                int third = number / 10 % 10;
                int fourth = number % 10;

                int result = first * 1000 + third * 100 + fourth * 10 + second;

                Console.WriteLine("Результат: " + result);
        }
    }
}
