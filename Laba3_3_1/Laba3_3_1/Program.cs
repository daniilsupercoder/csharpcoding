using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3_3_1
{
    /// <summary>
    /// Составьте алгоритм, который выводит на экран таблицу перевода 5, 6, 7, … 25 евро в рубли.Курс евро вводится с клавиатуры.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.Write("Enter Euro to Ruble exchange rate: ");
            double exchangeRate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Euro\tRuble");
            Console.WriteLine("---------------------");

            for (int euro = 5; euro <= 25; euro++)
            {
                double ruble = euro * exchangeRate;
                Console.WriteLine($"{euro}\t{ruble}");
            }

            Console.WriteLine();
        }
    }
}
