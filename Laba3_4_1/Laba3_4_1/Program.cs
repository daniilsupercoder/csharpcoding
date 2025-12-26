using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3_4_1
{
    /// <summary>
    /// Составьте алгоритм для нахождения суммы по следующей формуле:
    /// S = (x*x+x)/a* x(при x от 3 до 19)
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            double s = Solve(20);

            Console.WriteLine("Formula Answer ot 3 do 19:" + s);
        }

        private static double Solve(int a = 10)
        {
            double s = 0;            

            for (int x = 3; x <= 19; x++)
            {
                s = s + (Math.Pow(x, 2) + x) / a * x;
            }

            return s;
        }
    }
}
