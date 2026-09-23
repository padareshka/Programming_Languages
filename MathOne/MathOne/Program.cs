using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите большое основание трапеции");
            double bigBase = double.Parse(Console.ReadLine());

            Console.WriteLine("Высоту трапеции");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine("Высоту угол при основании в градусах");
            double angleInDegrees = double.Parse(Console.ReadLine());

            double AngleInRadians = angleInDegrees * Math.PI / 180;

            double smallBase = bigBase - 2 * height / Math.Tan(AngleInRadians);

            double area = height * (bigBase +  smallBase) / 2;

            double leg = height / Math.Sin(AngleInRadians);

            double perimeter = 2 * leg + bigBase + smallBase;

            Console.WriteLine("Площадь трапеции " + area);
            Console.WriteLine("Периметр трапеции " + perimeter);
        }

    }
}
