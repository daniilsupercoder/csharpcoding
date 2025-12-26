using System;
using System.Text;

/// <summary>
/// С 1 января 2000 года по некоторый день прошло m месяцев, определить название текущего
// месяца
/// </summary>
class Program
{
    static void Main()
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;

        Console.WriteLine("Введите количество месяцев, прошедших с 1 января 2000 года:");

        if (int.TryParse(Console.ReadLine(), out int months))
        {
            if (months >= 0)
            {
                string monthName = GetMonthName(months);
                Console.WriteLine($"Текущий месяц: {monthName}");
            }
            else
            {
                Console.WriteLine("Количество месяцев не может быть отрицательным.");
            }
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
        }

        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadKey();
    }

    static string GetMonthName(int monthsSince2000)
    {
        string[] monthNames = {
        "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь",
        "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь"
    };

        // Если нужно, чтобы 0 месяцев = "прошел 0 месяцев" = январь 2000
        // то 10 месяцев = ноябрь 2000 - это правильно

        // Если же нужно, чтобы 1 месяц = январь 2000, то используем:
        int currentMonthIndex = (monthsSince2000 - 1) % 12;
        if (currentMonthIndex < 0) currentMonthIndex += 12;

        return monthNames[currentMonthIndex];
    }
}