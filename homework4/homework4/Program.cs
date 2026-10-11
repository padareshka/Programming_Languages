using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework4
{
    internal class Program
    {

        static double F(double x)
        {
            return (-Math.Pow(x, 3) + 1 / (x * x + 1.0)) /
                   (1 + 5.0 / (x * x + x + 1));
        }

        static void Main(string[] args)
        {
            Console.Write("Введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            double y = F(x);

            Console.WriteLine("y = " + y);
        }
    }
}
