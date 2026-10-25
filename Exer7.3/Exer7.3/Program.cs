using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer7._3
{
    internal class Program
    {
        static void Decode(string p, out int x, out int y)
        {
            x = char.ToLower(p[0]) - 'a' + 1;
            y = p[1] - '0';
        }

        static bool Valid(string p)
        {
            return p.Length == 2 &&
                char.ToLower(p[0]) >= 'a' &&
                char.ToLower(p[0]) <= 'h' &&
                p[1] >= '1' && p[1] <= '8';
        }

        static bool Bishop(int x1, int y1, int x2, int y2)
        {
            return Math.Abs(x1 - x2) == Math.Abs(y1 - y2);
        }

        static bool Knight(int x1, int y1, int x2, int y2)
        {
            int dx = Math.Abs(x1 - x2);
            int dy = Math.Abs(y1 - y2);

            return (dx == 1 && dy == 2) ||
                   (dx == 2 && dy == 1);
        }

        static void Main(string[] args)
        {
            Console.Write("Белый слон: ");
            string a = Console.ReadLine();

            Console.Write("Черный конь: ");
            string b = Console.ReadLine();

            if (!Valid(a) || !Valid(b) ||
                string.Equals(a, b, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Некорректные позиции!");
                return;
            }

            Decode(a, out int x1, out int y1);
            Decode(b, out int x2, out int y2);

            if (Bishop(x1, y1, x2, y2))
                Console.WriteLine("Слон атакует коня");
            else
                Console.WriteLine("Слон не атакует коня");

            if (Knight(x2, y2, x1, y1))
                Console.WriteLine("Конь атакует слона");
            else
                Console.WriteLine("Конь не атакует слона");
        }
    }
}