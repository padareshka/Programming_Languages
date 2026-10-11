using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = Calculate();
            
            Console.WriteLine(Math.Round(x, 3));
        }

        //static double Calculate() => throw new NotImplementedException();
    }
}
