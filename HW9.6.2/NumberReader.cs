using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9._6._2
{
    class NumberReader
    {
        public delegate void NumberEnteredDelegate(int number);
        public event NumberEnteredDelegate NumberEnteredIvent;

        public void Read()
        {
            Console.WriteLine();
            Console.WriteLine("Введите значение 1 (для сортировки А-Я) или 2 (для сортировка Я-А): ");

            int number = Convert.ToInt32(Console.ReadLine());

            if (number != 1 && number != 2) throw new MyException("Ошибка: введите число 1 или 2");

            NumberEntered(number);
        }

        protected virtual void NumberEntered(int number)
        {
            NumberEnteredIvent?.Invoke(number);
        }
    }
}