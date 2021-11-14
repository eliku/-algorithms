using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using System.Collections.Generic;

namespace Lesson4
{
    public class arrayString:Program
    {
        [Benchmark]
        public void Testarray()
        {
            for (int i = 0; i < SrtCnt; i++)
            {
                var rString = "";
                for (var j = 0; j < 5; j++) rString += ((char)(rmd.Next(1, 26) + 64)).ToString().ToLower();
                array[i] = rString;
            }
             Array.FindAll(array, s => s.Equals("jjghj"));
        }
    }
}
