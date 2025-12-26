using System;
using System.Collections.Generic;

/*
 Задача 23. Дано: информация о студенте вуза содержит следующие
элементы:
а) фамилия, имя;
б) шифр группы;
в) массив оценок по каждой дисциплине за семестр (от 2 до 5).
Информация о студенте является элементом массива М[ ].
Требуется определить фамилии студентов, которые будут включены в приказ
на отчисление по результатам сессии (условие – по трем или более
дисциплинам каждая оценка — двойка).
Задача 23. Дано: информация о студенте вуза содержит следующие
элементы:
а) фамилия, имя;
б) шифр группы;
в) массив оценок по каждой дисциплине за семестр (от 2 до 5).
Информация о студенте является элементом массива М[ ].
Требуется определить фамилии студентов, которые будут включены в приказ
на отчисление по результатам сессии (условие – по трем или более
дисциплинам каждая оценка — двойка).
*/

class Program
{
    // Структура для хранения информации о студенте
    struct Student
    {
        public string LastName;
        public string FirstName;
        public string GroupCode;
        public int[] Grades;

        // Конструктор для удобного создания студентов
        public Student(string lastName, string firstName, string groupCode, int[] grades)
        {
            LastName = lastName;
            FirstName = firstName;
            GroupCode = groupCode;
            Grades = grades;
        }
    }

    static void Main(string[] args)
    {
        // Создаем массив студентов
        Student[] M = new Student[]
        {
            new Student("Ivanov", "Ivan", "IT-101", new int[] {5, 4, 3, 2, 4}),
            new Student("Petrov", "Petr", "IT-101", new int[] {2, 2, 2, 3, 4}),
            new Student("Sidorov", "Alexey", "IT-102", new int[] {2, 2, 2, 2, 3}),
            new Student("Kuznetsova", "Mariya", "IT-102", new int[] {5, 5, 4, 3, 5}),
            new Student("Smirnov", "Dmitriy", "IT-103", new int[] {2, 3, 2, 4, 2}),
            new Student("Vasilyev", "Sergey", "IT-103", new int[] {3, 3, 3, 3, 3})
        };

        Console.WriteLine("Spisok vseh studentov:");
        Console.WriteLine("======================");
        PrintAllStudents(M);

        Console.WriteLine("\nStudenti dlya otchisleniya:");
        Console.WriteLine("========================");

        // Получаем список студентов для отчисления
        List<string> studentsToExpel = GetStudentsForExpulsion(M);

        if (studentsToExpel.Count == 0)
        {
            Console.WriteLine("Net studentov dlya otchisleniya.");
        }
        else
        {
            foreach (string student in studentsToExpel)
            {
                Console.WriteLine(student);
            }
        }

        Console.WriteLine("\nNazmite klavishu dlya vihoda...");
        Console.ReadKey();
    }

    // Функция для определения студентов, подлежащих отчислению
    static List<string> GetStudentsForExpulsion(Student[] students)
    {
        //List<string> result = new List<string>();
        var result = new List<string>(); // Короткая запись

        foreach (Student student in students)
        {
            // Подсчитываем количество двоек
            int countTwos = CountTwos(student.Grades);

            // Если 3 или более двоек - добавляем в список для отчисления
            if (countTwos >= 3)
            {
                result.Add($"{student.LastName} {student.FirstName} (gruppa {student.GroupCode}) - {countTwos} dvoek");
            }
        }

        return result;
    }

    // Функция для подсчета количества двоек в массиве оценок
    static int CountTwos(int[] grades)
    {
        int count = 0; // счётчик // 1 // 2 // 3
        
        for(int i = 0; i < grades.Length; i++)
        {
            if (grades[i] == 2)
            {
                count = count + 1;
                // count++;
            }
        }

        //foreach (int grade in grades) // Только для чтения
        //{
        //    if (grade == 2)
        //    {
        //        count++;
        //    }
        //}
        return count;
    }

    // Функция для вывода информации о всех студентах
    static void PrintAllStudents(Student[] students)
    {
        foreach (Student student in students)
        {
            Console.Write($"{student.LastName} {student.FirstName} ({student.GroupCode}): ");
            Console.WriteLine(string.Join(", ", student.Grades));
        }
    }
}