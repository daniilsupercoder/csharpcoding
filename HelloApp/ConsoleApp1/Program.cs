using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите целое число: ");
        
        // Читаем ввод пользователя и пытаемся преобразовать в число
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            // Проверяем, больше ли число 30
            if (number > 30)
            {
                Console.WriteLine($"Число {number} больше 30. Вывод чисел от {number} до 20:");
                
                // Выводим числа от введенного числа до 20 (в порядке убывания)
                for (int i = number; i >= 20; i--)
                {
                    Console.Write(i);
                    
                    // Добавляем запятую между числами, кроме последнего
                    if (i > 20)
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine(); // Переход на новую строку после вывода
            }
            else
            {
                Console.WriteLine("Ошибка: Введенное число должно быть больше 30!");
            }
        }
        else
        {
            Console.WriteLine("Ошибка: Пожалуйста, введите целое число!");
        }
        
        // Ожидаем нажатия клавиши перед закрытием консоли
        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}