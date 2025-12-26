using System;
using System.Collections.Generic;
using System.Linq;

/*
23. Дано: информация о студенте вуза содержит следующие элементы:
а) фамилия, имя;
б) шифр группы;
в) массив оценок по каждой дисциплине за семестр (от 2 до 5).
Информация о студенте является элементом массива М[ ].
Требуется определить фамилии студентов, которые будут включены в приказ
на стипендию по результатам сессии (условие – оценки по всем дисциплинам
не ниже четверки).
*/
namespace StudentScholarship
{
    // Класс для хранения информации о студенте
    class Student
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string GroupCode { get; set; }
        public int[] Grades { get; set; }

        public Student(string lastName, string firstName, string groupCode, int[] grades)
        {
            LastName = lastName;
            FirstName = firstName;
            GroupCode = groupCode;
            Grades = grades;
        }

        // Метод для проверки eligibility для стипендии
        public bool IsEligibleForScholarship()
        {
            bool result = true;

            foreach (var element in Grades)
            {
                if (element < 4)
                {
                    return false;
                }
            }

            return result;

            //return Grades.All(grade => grade >= 4);
        }

        public override string ToString()
        {
            return $"{LastName} {FirstName} (gruppa {GroupCode})";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Создаем список студентов
            List<Student> students = new List<Student>
            {
                new Student("Ivanov", "Alex", "IT-101", new int[] {5, 4, 5, 4}),
                new Student("Petrova", "Mariya", "IT-101", new int[] {4, 4, 4, 4}),
                new Student("Sidorov", "Dmitriy", "IT-102", new int[] {5, 5, 5, 5}),
                new Student("Kozlova", "Annay", "IT-102", new int[] {4, 3, 5, 4}),
                new Student("Nikolaev", "Sergey", "IT-101", new int[] {4, 4, 4, 5})
            };

            Console.WriteLine("Spisok vseh studentov:");
            students.ForEach(s => Console.WriteLine($"{s} - otsenki: {string.Join(", ", s.Grades)}"));

            //// Просто пример ещё одного форыча
            //Console.WriteLine("Prosto vivedem IMENA");
            //students.ForEach(i => Console.WriteLine(i.FirstName));

            // Получаем студентов на стипендию с использованием LINQ
            var scholarshipStudents = students
                .Where(s => s.IsEligibleForScholarship())
                .Select(s => s.ToString())
                .ToList();

            Console.WriteLine("\nStudenty, u kotorih budet stipendiya:");

            if (scholarshipStudents.Any())
            {
                scholarshipStudents.ForEach(Console.WriteLine);
            }
            else
            {
                Console.WriteLine("Net studentov, sootvetstvuyushih usloviyam dlya stipendii.");
            }

            Console.ReadLine();
        }
    }
}