using System;
using System.IO;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;

            // Читаем вс
            //
            //
            //
            //
            //
            //
            //
            // е строки из файла
            string[] lines = File.ReadAllLines("lines.txt");

            if (lines.Length == 0)
            {
                Console.WriteLine("Файл пуст.");
                return;
            }

            // Находим максимальную длину строки
            int maxLength = lines.Max(line => line.Length);

            // Выбираем все строки с максимальной длиной, сохраняя порядок
            var longestLines = lines.Where(line => line.Length == maxLength);

            // Выводим результат
            Console.WriteLine($"Строки наибольшей длины ({maxLength} символов):");
            Console.WriteLine("======================================");

            foreach (string line in longestLines)
            {
                Console.WriteLine(line);
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Файл lines.txt не найден.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }
}