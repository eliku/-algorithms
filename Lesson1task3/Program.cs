using System;
/*Домашнее задание
 * Число фибоначи
 * Требуется реализовать рекурсивную версию и версию без рекурсии (через цикл).
 */

namespace Lesson1task3
{
    class Program
    {
        //рекурсия
        static int Fibonachi(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fibonachi(n - 1) + Fibonachi(n - 2);
        }

        //без рекурсии
        static int FibonachiNo(int n)
        {
            int Fib = 0, Fib1= 0, Fib2 = 1, i = 1;

            if (n == 0) return 0;
            if (n == 1) return 1;

            while (i < n)
            {
                Fib = Fib1 + Fib2;
                Fib1 = Fib2;
                Fib2 = Fib;
                i++;
            }

            return Fib;
        }

        public static void Main(string[] args)
        {

            Console.WriteLine("Введите число");
            Console.WriteLine($"Число Фибоначи = {Fibonachi(Convert.ToInt32(Console.ReadLine()))}");

            Console.WriteLine("Введите число");
            Console.WriteLine($"Число Фибоначи = {FibonachiNo(Convert.ToInt32(Console.ReadLine()))}");
        }

    }
}
