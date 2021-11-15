using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Lesson4
{
    public class Program
    {
        public static Random rmd = new Random();
        public static int SrtCnt = rmd.Next(0, 10000);
        public static string[] array = new string[SrtCnt];

        public static void Main(string[] args)
        {


            for (int i = 0; i < SrtCnt; i++) {
                var rString = "";
                for (var j = 0; j < 5; j++) rString += ((char)(rmd.Next(1, 26) + 64)).ToString().ToLower();
                array[i] = rString;
            }

            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);

            
        }
    }
}
