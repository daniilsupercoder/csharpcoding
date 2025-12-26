using System;
using System.Text;

// S = корень((кос(4у))^2 + 7,151)
namespace Laba1_16_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Программа для вычисления функции: S = корень cos4у ^ 2 + 7, 151");

            Console.Write("Введите значение y:");
            double y = double.Parse(Console.ReadLine());

            double S = Math.Sqrt(Math.Pow(Math.Cos(4 * y), 2) + 7.151);

            Console.WriteLine($" S = { S}");

            Console.ReadKey();
        }
    }
}
