using System;
using System.Linq;

namespace Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[] { -1, 0, -10, 8, -1, 0, 78 };
            BucketSort.Sort(ref data);
            foreach (int value in data.Reverse())
            {
                Console.Write(" " + value);
            }
        }
    }
}
