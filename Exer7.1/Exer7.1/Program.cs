using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer7._1
{
    internal class Program
    {
        static bool IsNotMultiple(int n)
        {
            return n % 5 != 0 && n % 8 != 0;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите целое число: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(IsNotMultiple(n));
        }
    }
}
