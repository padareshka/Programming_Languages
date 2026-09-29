using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первый член прогрессии");
            double firstNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите знаменатель прогрессии");
            double secondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите номер члена");
            double thirdNumber = double.Parse(Console.ReadLine());

            double result = firstNumber * Math.Pow(secondNumber, thirdNumber - 1);

            Console.WriteLine("Результат: " + result);
        }
    }
}
