using System;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace HW9._6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberReader numberReader = new();
            numberReader.NumberEnteredIvent += SortLastName;

            while (true)
            {
                try
                {
                    numberReader.Read();
                }
                catch (MyException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка FormatException");
                }
                catch (IOException)
                {
                    Console.WriteLine("Ошибка IOException");
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Ошибка ArgumentNullException");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Ошибка ArgumentOutOfRangeException");
                }
            }
        }

        static void SortLastName(int number)
        {
            List<string> LastNames =
            [
                "Иванов",
                "Петров",
                "Сидоров",
                "Васильев",
                "Михайлов"
            ];

            List<string> NewLastNames = [];

            switch (number)
            {
                case 1:
                    {
                        NewLastNames = [.. LastNames.OrderBy(s => s)];
                        Console.WriteLine("Отсортированный список от А до Я:");
                        break;
                    };
                case 2:
                    {
                        NewLastNames = [.. LastNames.OrderBy(s => s)];
                        NewLastNames.Reverse();
                        Console.WriteLine("Отсортированный список от Я до А:");
                        break;
                    }
            }

            foreach (var item in NewLastNames)
            {
                Console.WriteLine(item);
            }

        }

    }

}