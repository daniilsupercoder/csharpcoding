using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Daniil();

            Denis("call");
        }

        (bool, DateTime) IsWeatherGoodAtDate(DateTime date)
        {
            return (true, date);
        }

        bool IsWeatherGoodToday()
        {
            return false;
        }

        static int Denis(string message)
        {
            Console.WriteLine($"Daniil says:{ message }");
            return 112; 
        }

        static (int, int, string) SuperKortgeg()
        {
            return (2, 1, "Helo");
        }


        static void Daniil()
        {
            Denis("call me");
        }

        void Sergey()
        {

        }
    }
}
