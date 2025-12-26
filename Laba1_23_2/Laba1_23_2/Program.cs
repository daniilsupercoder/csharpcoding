using System;
using System.Text;

namespace Laba1_23_2
{
    internal class Program
    {
        // R = ((sin(y))^2 + 0,3d) /(e^y + ln(d))
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Программа для вычисления функции: R = ((sin(y))^2 + 0,3d) /(e^y + ln(d))");

            Console.Write("Введите значение y:");
            double y = double.Parse(Console.ReadLine());

            Console.Write("Введите значение d:");
            double d = double.Parse(Console.ReadLine());

            double R = (Math.Pow(Math.Sin(y), 2) + 0.3 * d) /
                        (Math.Pow(Math.E, y) + Math.Log(d));

            Console.WriteLine($" R = {R}");

            Console.ReadKey();

        }
    }
}
