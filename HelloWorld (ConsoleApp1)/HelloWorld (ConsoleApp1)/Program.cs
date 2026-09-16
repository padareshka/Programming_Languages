using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld__ConsoleApp1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет, мир!");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Hello, world!");
            Console.ResetColor();

            //Console.ReadKey();
        }
    }
}
