using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3_1_1
{
    public class Cat
    {
        public string Name { get; set; } // Свойство Имя кошки
        public int Age { get; set; } // Свойство Возраст кошки
        public void Meow() // Метод Мяу
        {
            Console.WriteLine("Meow!");
            Console.WriteLine("Meow!");
            Console.WriteLine("Meow!");
            Console.WriteLine("Meow!");
        }
    }
}
