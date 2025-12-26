using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3_1_1
{
    /// <summary>
    /// Вывести на экран таблицу перевода из градусов по шкале Цельсия в
    /// градусы по Фаренгейту, для значений от 15 до 30, шаг 1 градус.Формула
    /// перевода из Цельсия в Фаренгейты F=(c*1.8)+32.
    /// </summary>
    internal class Program
    {
        string Surname; // Поле

        public string Name { get; }
        public string Description { get; }
        public string Author { get; set; }


        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Celsius\tFarenheit");
            Console.WriteLine("---------------------");
            for (int celsius = 15; celsius <= 30; celsius++)
            {
                double farenheit = p.CeliusToFarenheit(celsius);
                Console.WriteLine($"{celsius}\t{farenheit}");
            }

            // Сложные типы данных = Complex data types = Составные типы данных

            // Создание экземпляра класса Cat
            var myCat = new Cat();

            myCat.Name = "Whiskers"; // Установка свойства Name
            myCat.Age = 3; // Установка свойства Age

            myCat.Meow(); // Вызов метода Meow

            // Использования var
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            var numbers2 = new int[] { 1, 2, 3, 4, 5 };

            // Простые типы данных = Примитивные типы данных
            bool isTrue = true; // Логический тип данных
            int age = 25; // Целочисленный тип данных
            double height = 175.5; // Тип данных с плавающей точкой
            char grade = 'A'; // Символьный тип данных
            string name = "John Doe"; // Строковый тип данных
        }

        double CeliusToFarenheit(double celsius)
        {
            return (celsius * 1.8) + 32;
        }
    }
}
