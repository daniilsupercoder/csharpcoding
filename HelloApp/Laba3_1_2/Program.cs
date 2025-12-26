using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите два действительных числа:");
        Console.Write("x = ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("y = ");
        double y = Convert.ToDouble(Console.ReadLine());

        // Определяем границы для целых чисел
        int start = (int)Math.Ceiling(Math.Min(x, y));
        int end = (int)Math.Floor(Math.Max(x, y));

        // Если start > end, значит между x и y нет целых чисел
        if (start > end)
        {
            Console.WriteLine($"Между {x} и {y} нет целых чисел.");
            Console.WriteLine($"Количество целых чисел: 0");
        }
        else
        {
            Console.WriteLine($"Целые числа между {x} и {y} в порядке возрастания:");

            int count = 0;
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
                count++;
            }

            Console.WriteLine($"\nКоличество целых чисел: {count}");
        }

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}