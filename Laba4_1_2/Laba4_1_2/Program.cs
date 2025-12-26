using System;

class Program
{
    /// <summary>
    /// 1. Ввести два одномерных целочисленных массива A и B из N и M элементов
    /// соответственно.
    /// </summary>
    static void Main()
    {
        Console.WriteLine("VVod dvuh odnomernih celochislennih massivov");
        Console.WriteLine("===========================================");

        // Ввод первого массива A
        Console.Write("Введите размер первого массива A (N): ");
        int n = int.Parse(Console.ReadLine());
        int[] A = new int[n];

        Console.WriteLine($"Введите {n} элементов массива A:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"A[{i}] = ");
            A[i] = int.Parse(Console.ReadLine());
        }

        // Ввод второго массива B
        Console.Write("\nВведите размер второго массива B (M): ");
        int m = int.Parse(Console.ReadLine());
        int[] B = new int[m];

        Console.WriteLine($"Введите {m} элементов массива B:");
        for (int i = 0; i < m; i++)
        {
            Console.Write($"B[{i}] = ");
            B[i] = int.Parse(Console.ReadLine());
        }

        // Вывод массивов
        Console.WriteLine("\n=== Введенные массивы ===");
        Console.Write("Массив A: ");
        PrintArray(A);

        Console.Write("Массив B: ");
        PrintArray(B);

        // Дополнительные операции с массивами (пример)
        Console.WriteLine("\n=== Дополнительная информация ===");
        Console.WriteLine($"Размер массива A: {A.Length}");
        Console.WriteLine($"Размер массива B: {B.Length}");
        Console.WriteLine($"Сумма элементов A: {SumArray(A)}");
        Console.WriteLine($"Сумма элементов B: {SumArray(B)}");

        // Поиск общих элементов
        FindCommonElements(A, B);

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }

    // Метод для вывода массива
    static void PrintArray(int[] array)
    {
        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            if (i < array.Length - 1)
                Console.Write(", ");
        }
        Console.WriteLine("]");
    }

    // Метод для вычисления суммы элементов массива
    static int SumArray(int[] array)
    {
        int sum = 0;////
        foreach (int num in array)
        {
            sum += num; // sum = sum + num
        }
        return sum;
    }

    // Метод для поиска общих элементов в двух массивах
    static void FindCommonElements(int[] A, int[] B)
    {
        Console.Write("Общие элементы: ");
        bool foundCommon = false;

        for (int i = 0; i < A.Length; i++)
        {
            for (int j = 0; j < B.Length; j++)
            {
                if (A[i] == B[j])
                {
                    Console.Write(A[i] + " ");
                    foundCommon = true;
                    break; // чтобы избежать дубликатов
                }
            }
        }

        if (!foundCommon)
        {
            Console.Write("нет общих элементов");
        }
        Console.WriteLine();
    }
}