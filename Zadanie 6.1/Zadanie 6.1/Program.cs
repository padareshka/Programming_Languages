using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6._1
{
    internal class Program
    {

        static string ToLeet(string text)
        {
            text = text.ToUpper();

            text = text.Replace("A", "4");
            text = text.Replace("B", "8");
            text = text.Replace("C", "(");
            text = text.Replace("D", "|)");
            text = text.Replace("E", "3");
            text = text.Replace("F", "|=");
            text = text.Replace("G", "6");
            text = text.Replace("H", "|-|");
            text = text.Replace("I", "!");
            text = text.Replace("J", ")");
            text = text.Replace("K", "|<");
            text = text.Replace("L", "1");
            text = text.Replace("M", "|\\/|");
            text = text.Replace("N", "|\\|");
            text = text.Replace("O", "0");
            text = text.Replace("P", "|>");
            text = text.Replace("Q", "9");
            text = text.Replace("R", "|2");
            text = text.Replace("S", "5");
            text = text.Replace("T", "7");
            text = text.Replace("U", "|_|");
            text = text.Replace("V", "\\/");
            text = text.Replace("W", "\\/\\/");
            text = text.Replace("X", "><");
            text = text.Replace("Y", "'/");
            text = text.Replace("Z", "2");

            return text;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст на английском:");
            string text = Console.ReadLine();

            string result = ToLeet(text);

            Console.WriteLine(result);
        }
    }
}

