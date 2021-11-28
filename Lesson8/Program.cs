using System;
using System.Linq;

namespace Lesson8
{
    class Program
    {
        public class TestCase
        {
            public int[] data { get; set; }
            public int Expected { get; set; }
            public Exception ExpectedException { get; set; }
        }
        static int arrSort(int[] arr)
        { 
            BucketSort.Sort(ref arr);
            return arr.Length;
        }
        static void TestSort(TestCase testCase)
        {
            try
            {
                var actual = arrSort(testCase.data);

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
                data = new int[] { -1, 0, -10, 8, -1, 0, 78 },

                Expected = 7,
                ExpectedException = null
            };

            var testCase2 = new TestCase()
            {
                data = new int[] { -1, 0, -10, 8, -1, 0, 78 },
                Expected = 5,
                ExpectedException = null
            };

            TestSort(testCase1);
            TestSort(testCase2);

        }
    }
}
