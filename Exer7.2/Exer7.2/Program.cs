using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer7._2
{
    internal class Program
    {
        static bool IsInside(double x, double y)
        {
            return x >= 2 || (y >= 0.5 && y <= 1.5);
        }

        static void Main(string[] args)
        {
            Console.Write("Введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(IsInside(x, y));
        }
    }
}
