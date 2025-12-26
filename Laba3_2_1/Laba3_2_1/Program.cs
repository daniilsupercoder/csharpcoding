using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3_2_1
{
    internal class Program
    {
        /// <summary>
        /// Написать алгоритм, который выводит на экран таблицу умножения на 7.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const int multiplier = 7;

            for(int i = 1; i <= 10; i++)
            {
                int result = multiplier * i;
                Console.WriteLine($"{multiplier} x {i} = {result}");
            }
        }
    }
}
