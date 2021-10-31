using System;

namespace Lesson2_task2
{
    class Program
    {
        static  int[] array = { 0, 34, 2, 45, 3, 6 };

        public class TestCase
        {
            public int X { get; set; }
            public int Expected { get; set; }
            public Exception ExpectedException { get; set; }
        }
        public static void Main(string[] args)
        {
            var testCase1 = new TestCase()
            {
                X = 0,
                Expected = 0,
                ExpectedException = null
            };

            var testCase2 = new TestCase()
            {
                X = 34,
                Expected = 1,
                ExpectedException = null
            };

            var testCase3 = new TestCase()
            {
                X = 67,
                Expected = 2,
                ExpectedException = null
            };
            BinarySearchTest(testCase1);
            BinarySearchTest(testCase2);
            BinarySearchTest(testCase3);
        }

        public static void BinarySearchTest(TestCase testCase)
        {
            try
            {
                Array.Sort(array);

                var actual = BinarySearch(array, testCase.X);

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

        public static int BinarySearch(int[] inputArray, int searchValue)
        {
            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (searchValue == inputArray[mid])
                {
                    return mid;
                }
                else if (searchValue < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;
        }
    }
}
