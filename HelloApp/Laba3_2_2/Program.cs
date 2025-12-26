using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите действительное число x:");
        double x = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите действительное число y:");
        double y = double.Parse(Console.ReadLine());

        // Определяем границы диапазона
        double min = Math.Min(x, y);
        double max = Math.Max(x, y);

        // Находим первое целое число в диапазоне (не включая границы)
        int start = (int)Math.Floor(min) + 1;

        // Находим последнее целое число в диапазоне (не включая границы)
        int end = (int)Math.Ceiling(max) - 1;

        int count = 0;

        Console.WriteLine("\nЦелые числа между {0} и {1} в порядке убывания:", x, y);

        // Выводим числа в порядке убывания
        for (int i = end; i >= start; i--)
        {
            Console.Write(i + " ");
            count++;
        }

        Console.WriteLine("\nКоличество целых чисел: " + count);

        // Если целых чисел нет
        if (count == 0)
        {
            Console.WriteLine("Между данными числами нет целых чисел.");
        }
    }
}