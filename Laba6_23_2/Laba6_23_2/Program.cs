using System;
using System.Linq;
using System.Text;

namespace AeroflotApp
{
    // Структура Аэрофлот
    public struct Aeroflot
    {
        public string Destination;      // пункт назначения
        public string AircraftType;    // тип самолета
        public int Seats;              // количество мест
        public decimal Price1;         // цена 1
        public decimal Price2;         // цена 2
        public decimal Price3;         // цена 3

        // Конструктор для удобства инициализации
        public Aeroflot(string destination, string aircraftType, int seats, decimal price1, decimal price2, decimal price3)
        {
            Destination = destination;
            AircraftType = aircraftType;
            Seats = seats;
            Price1 = price1;
            Price2 = price2;
            Price3 = price3;
        }

        // Метод для вывода информации о рейсе
        public void DisplayInfo()
        {
            Console.WriteLine($"Пункт назначения: {Destination}");
            Console.WriteLine($"Тип самолета: {AircraftType}");
            Console.WriteLine($"Количество мест: {Seats}");
            Console.WriteLine($"Цены: {Price1}, {Price2}, {Price3}");
            Console.WriteLine();
        }
    }

    class Program
    {
        // Метод Cort, который возвращает кортеж по исходному кортежу
        public static (string destination, string aircraftType, string flightNumber, decimal averagePrice, string seatsMatch) Cort(
            (string destination, int seats, string departureTime, decimal price) inputTuple,
            Aeroflot[] aeroflotArray)
        {
            // Поиск соответствующей записи в массиве структур по пункту назначения
            var matchingFlight = aeroflotArray.FirstOrDefault(a => a.Destination == inputTuple.destination);

            // Если запись не найдена, возвращаем значения по умолчанию
            if (matchingFlight.Destination == null)
            {
                return ("Не найдено", "Не найден", "Не найден", 0, "нет");
            }

            // Генерация номера рейса: пункт назначения + время отправки
            string flightNumber = $"{inputTuple.destination}_{inputTuple.departureTime}";

            // Расчет средней цены из трех цен структуры
            decimal averagePrice = (matchingFlight.Price1 + matchingFlight.Price2 + matchingFlight.Price3) / 3;

            // Проверка совпадения количества мест
            string seatsMatch = matchingFlight.Seats == inputTuple.seats ? "да" : "нет";

            return (matchingFlight.Destination, matchingFlight.AircraftType, flightNumber, averagePrice, seatsMatch);
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("=== Аэрофлот - Система обработки рейсов ===\n");

            // Создание массива структур из 5 элементов и заполнение программно
            Aeroflot[] flights = new Aeroflot[5];

            flights[0] = new Aeroflot("Москва", "Boeing 737", 180, 5000, 5500, 6000);
            flights[1] = new Aeroflot("Санкт-Петербург", "Airbus A320", 150, 4500, 4800, 5200);
            flights[2] = new Aeroflot("Сочи", "Boeing 777", 300, 7000, 7500, 8000);
            flights[3] = new Aeroflot("Екатеринбург", "Sukhoi Superjet", 100, 6000, 6500, 7000);
            flights[4] = new Aeroflot("Владивосток", "Airbus A330", 250, 12000, 13000, 14000);

            // Вывод информации о всех рейсах
            Console.WriteLine("Доступные рейсы:");
            Console.WriteLine("================\n");

            for (int i = 0; i < flights.Length; i++)
            {
                Console.WriteLine($"Рейс {i + 1}:");
                flights[i].DisplayInfo();
            }

            // Создание тестовых входных кортежей
            var inputTuple1 = ("Москва", 180, "10:30", 5500m);
            var inputTuple2 = ("Санкт-Петербург", 200, "14:15", 5000m);
            var inputTuple3 = ("Сочи", 300, "08:45", 7500m);
            var inputTuple4 = ("Калининград", 150, "16:20", 6000m); // Несуществующий пункт назначения

            // Обработка кортежей методом Cort и вывод результатов
            Console.WriteLine("Результаты обработки кортежей:");
            Console.WriteLine("===============================\n");

            ProcessAndDisplay(inputTuple1, flights, "Тест 1");
            ProcessAndDisplay(inputTuple2, flights, "Тест 2");
            ProcessAndDisplay(inputTuple3, flights, "Тест 3");
            ProcessAndDisplay(inputTuple4, flights, "Тест 4 (несуществующий пункт)");

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }

        // Вспомогательный метод для обработки и отображения результатов
        static void ProcessAndDisplay((string destination, int seats, string departureTime, decimal price) inputTuple,
                                     Aeroflot[] flights, string testName)
        {
            Console.WriteLine($"{testName}:");
            Console.WriteLine($"Входные данные: {inputTuple}");

            var result = Cort(inputTuple, flights);

            Console.WriteLine($"Результат:");
            Console.WriteLine($"  Пункт назначения: {result.destination}");
            Console.WriteLine($"  Тип самолета: {result.aircraftType}");
            Console.WriteLine($"  Номер рейса: {result.flightNumber}");
            Console.WriteLine($"  Средняя цена: {result.averagePrice:F2}");
            Console.WriteLine($"  Совпадает количество мест: {result.seatsMatch}");
            Console.WriteLine();
        }
    }
}