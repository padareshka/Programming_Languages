using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    internal class Program
    {
        static double F(double a, double b)
        {
            return Math.Sin((Math.Pow(a, a) + 1) / (Math.Pow(b, b) + 1));
        }

        static void Main(string[] args)
        {
            double x = F(2, 3) + F(3, 5) + F(4, 3);

            Console.WriteLine("x = " + x.ToString("F3"));
        }
    }
}
