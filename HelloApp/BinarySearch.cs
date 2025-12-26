using System;

public class Class1
{
/// <summary>
/// Сложность О (от логорифма N)
///
/// </summary>
/// <param name="array"></param>
/// <param name="target"></param>
/// <returns></returns>
    public static int BinarySearchIterative(int[] array, int target)
    {
        int left = 0;
        int right = array.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2; // Предотвращает переполнение

            if (array[mid] == target)
                return mid; // Элемент найден

            if (array[mid] < target)
                left = mid + 1; // Ищем в правой половине
            else
                right = mid - 1; // Ищем в левой половине
        }

        return -1; // Элемент не найден
    }
}
