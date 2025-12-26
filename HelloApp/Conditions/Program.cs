using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            if (name == "Daniil")
            {
                Console.WriteLine("Hello Daniil");
            }
            else if (name == "Mama")
            {
                Console.WriteLine("Mama");
            }
            else if (name == "Denis")
            {
                Console.WriteLine("Denis");
            }
            else
            {
                Console.WriteLine("Sergey");
            }

            Console.ReadLine();
        }
    }
}
