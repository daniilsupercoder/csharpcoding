using System.Text;

namespace BubbleSortBase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.WriteLine("Сортировка пузырьком");
            Console.WriteLine("--------------------");

            int[] numbers = { 64, 34, 25, 12, 22, 11, 90 };

            Console.WriteLine("Исходный массив:");
            Console.WriteLine(string.Join(", ", numbers));

            BubbleSort(numbers);

            Console.WriteLine("\nОтсортированный массив:");
            Console.WriteLine(string.Join(", ", numbers));
        }

        /*Анализ сложности
Временная сложность:
    Худший случай(обратно отсортированный массив):

        Число сравнений: (n-1) + (n-2) + ... + 1 = n(n-1)/2

        O(n²) операций сравнений и обменов

    Средний случай(случайный массив):

        Примерно половина от худшего случая

        O(n²) (квадратичная сложность)

    Лучший случай(уже отсортированный массив) :

        Базовая версия: O(n²) сравнений, но O(1) обменов

        Оптимизированная версия: O(n) сравнений(один проход), O(1) обменов

Пространственная сложность:
    O(1) дополнительной памяти(сортировка на месте)

    Используется только константное количество временных переменных*/
        public static void BubbleSort(int[] array)
        {
            int n = array.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        // Меняем местами элементы
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
    }
}
