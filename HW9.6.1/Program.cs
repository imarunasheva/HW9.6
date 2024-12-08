using System;

namespace HW9._6._1
{
    class Program
    {
        static string RandomPrize(byte a, byte b)
        {
            string[] Prize =
            [
                "Машина",
                "Цветы",
                "Деньги",
                "Игрушка",
                "Вкусняшки",
                "Машина",
                "Цветы",
                "Деньги",
                "Игрушка",
                "Вкусняшки",
            ];

            int c = a / b;

            return Prize[c];
        }
        
        static void Main(string[] args)
        {
            while (true)
            {
                MyException ex1 = new("Ошибка: введите значение от 1 до 11");
                FormatException ex2 = new("Ошибка: некорректный формат значения");
                DivideByZeroException ex3 = new("Ошибка: значение 0 не подходит");
                OverflowException ex4 = new("Ошибка: слишком большое число");
                IndexOutOfRangeException ex5 = new("Вы ничего не выиграли");

                Exception[] arr = [ex1, ex2, ex3, ex4, ex5];


                try
                {
                    Console.Write("Введите первое целое число от 1 до 11: ");    
                    byte a = byte.Parse(Console.ReadLine());
                    
                    Console.Write("Введите второе целое число от 1 до 11: ");
                    byte b = byte.Parse(Console.ReadLine());
                    
                    if (a > 11 ||  b > 11) throw ex1;

                    var result = RandomPrize(a, b);
                    Console.WriteLine("Ваш приз: " + result);
                }

                catch (MyException)
                {
                    Console.WriteLine(ex1.Message);
                }
                catch (FormatException)
                {
                    Console.WriteLine(ex2.Message);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine(ex3.Message);
                }
                catch (OverflowException)
                {
                    Console.WriteLine(ex4.Message);
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine(ex5.Message);
                }
            }
        }
    }  
}        
        
        