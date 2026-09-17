using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_HM1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Иван Бунин");

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Вечер");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("О счастье мы всегда лишь вспоминаем.\r\nА счастье всюду. Может быть, оно\r\nВот этот сад осенний за сараем\r\nИ чистый воздух, льющийся в окно.\r\n");
            Console.ResetColor();
        }
    }
}
