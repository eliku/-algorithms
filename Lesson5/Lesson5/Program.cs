using System;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            var rmd = new Random();
            int SrtCnt = rmd.Next(0,10000);
            string[] array = new string[SrtCnt];
            for (int i = 0; i < SrtCnt; i++) {
                var rString = "";
                for (var j = 0; j < 5; j++) rString += ((char)(rmd.Next(1, 26) + 64)).ToString().ToLower();
                array[i] = rString;
            }
        }
    }
}
