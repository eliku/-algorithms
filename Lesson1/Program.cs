using System;
/* Домашнее задание
 * Требуется реализовать на C# функцию согласно блок-схеме.
 * Блок-схема описывает алгоритм проверки, простое число или нет.

 */
namespace Lesson1
{
    class Program
    {
        public class TestCase
        {
            public int Num { get; set; }
            public string Expected { get; set; }
            public Exception ExpectedException { get; set; }
        }

        static string PrimeNumber(int n)
        {
            //блок переменных
            int d, i;

            d = 0;
            i = 2;

            while (i < n)
            {
                if ((n % i) == 0) d++;
                i++;
            }
            if (d == 0)
            {
                return $"Число простое";
            }
            else
            {
                return $"Число не простое";
            }

        }

        static void TestPrimeNumber(TestCase testCase)
        {
            try
            {

                var actual = PrimeNumber(testCase.Num);

                if (actual == testCase.Expected)
                {
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
                }
            }
            catch (Exception ex)
            {
                if (testCase.ExpectedException != null)
                {
                    //TODO add type exception tests;
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
                }
            }
        }

        static void Main(string[] args)
        {
            var testCase1 = new TestCase()
            {
                Num = 7,
                Expected = $"Число простое",
                ExpectedException = null

            };

            var testCase2 = new TestCase()
            {
                Num = 22,
                Expected = $"Число простое",
                ExpectedException = null

            };

            var testCase3 = new TestCase()
            {
                Num = 22,
                Expected = $"Число не простое",
                ExpectedException = null

            };

            TestPrimeNumber(testCase1);
            TestPrimeNumber(testCase2);
            TestPrimeNumber(testCase3);
        }
    }
}

