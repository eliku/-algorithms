using System;
/* Домашнее задание
 * Требуется реализовать на C# функцию согласно блок-схеме.
 * Блок-схема описывает алгоритм проверки, простое число или нет.

 */
namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            //блок переменных
            int number, d, i;
            //ввод числа
            Console.WriteLine("Введите число");
            number = Convert.ToInt32(Console.ReadLine());

            d = 0;
            i = 2;

            while (i < number)
            {
                if ((number % i) == 0) d++;
                i++;
            }
            if (d == 0)
            {
                Console.WriteLine($"Число {number} простое");
            }
            else
            {
                Console.WriteLine($"Число {number} не простое");
            }



        }
    }
}
