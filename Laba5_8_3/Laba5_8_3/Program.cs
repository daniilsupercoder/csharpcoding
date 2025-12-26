using System;

/// <summary>
/// Напечатайте календарь заданного месяца 1998 года, зная, что 1 января 1998 года – четверг.
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("КАЛЕНДАРЬ 1998 ГОДА");
        Console.WriteLine("===================");

        Console.Write("Введите номер месяца (1-12): ");
        int month = int.Parse(Console.ReadLine());

        if (month < 1 || month > 12)
        {
            Console.WriteLine("Ошибка: месяц должен быть от 1 до 12");
            return;
        }

        PrintCalendar(1998, month);
    }

    static void PrintCalendar(int year, int month)
    {
        // Названия месяцев
        string[] monthNames = {
            "", "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь",
            "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь"
        };

        // Названия дней недели
        string[] dayNames = { "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс" };

        // Количество дней в каждом месяце (не високосный год)
        int[] daysInMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        Console.WriteLine($"\n{monthNames[month]} {year}");
        Console.WriteLine(new string('-', 20));

        // Выводим заголовок с днями недели
        foreach (string dayName in dayNames)
        {
            Console.Write($"{dayName} ");
        }
        Console.WriteLine();

        // Вычисляем день недели для 1 числа заданного месяца
        int firstDayOfWeek = GetFirstDayOfWeek(year, month);

        // Выводим пробелы до первого дня месяца
        for (int i = 0; i < firstDayOfWeek; i++)
        {
            Console.Write("   ");
        }

        // Выводим числа месяца
        int daysCount = daysInMonth[month];
        for (int day = 1; day <= daysCount; day++)
        {
            Console.Write($"{day,2} ");

            // Переход на новую строку после воскресенья
            if ((day + firstDayOfWeek) % 7 == 0)
            {
                Console.WriteLine();
            }
        }

        Console.WriteLine("\n");
    }

    static int GetFirstDayOfWeek(int year, int month)
    {
        // 1 января 1998 - четверг (индекс 3 в массиве, где Пн=0)
        // Но в нашем календаре понедельник идет первым, поэтому четверг = 3

        // Вычисляем количество дней от 1 января до 1 числа заданного месяца
        int daysFromStart = 0;

        // Суммируем дни предыдущих месяцев
        for (int m = 1; m < month; m++)
        {
            daysFromStart += GetDaysInMonth(m, year);
        }

        // Вычисляем день недели для 1 числа заданного месяца
        // 1 января = четверг (3)
        int firstDay = (3 + daysFromStart) % 7;

        return firstDay;
    }

    static int GetDaysInMonth(int month, int year)
    {
        switch (month)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                return 31;
            case 4:
            case 6:
            case 9:
            case 11:
                return 30;
            case 2:
                return IsLeapYear(year) ? 29 : 28;
            default:
                return 0;
        }
    }

    static bool IsLeapYear(int year)
    {
        // 1998 не високосный год
        return false;
    }
}