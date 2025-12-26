using System;

/// <summary>
/// Дано целое число п (1 п  365). Определить, каким днем недели (понедельником, вторником,
//…, воскресеньем) является п-й день невисокосного года, в котором 1 января является
// понедельником.
/// </summary>
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Введите номер дня года (1-365): ");
        int n = int.Parse(Console.ReadLine());

        // Проверка корректности ввода
        if (n < 1 || n > 365)
        {
            Console.WriteLine("Ошибка: число должно быть в диапазоне от 1 до 365");
            return;
        }

        // Определяем день недели
        // 1 января - понедельник (остаток 0)
        // Каждый следующий день сдвигает день недели на 1
        int dayOfWeek = (n - 1) % 7;

        string dayName = GetDayName(dayOfWeek);

        Console.WriteLine($"{n}-й день года - это {dayName}");
    }

    static string GetDayName(int dayIndex)
    {
        return dayIndex switch
        {
            0 => "понедельник",
            1 => "вторник",
            2 => "среда",
            3 => "четверг",
            4 => "пятница",
            5 => "суббота",
            6 => "воскресенье",
            _ => "неизвестный день"
        };
    }
}