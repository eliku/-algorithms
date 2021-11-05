using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        }
    }

    public class BechmarkClass
    {

        [Benchmark]
        public void TestPointClass()
        {
            PointClass PointNew = new PointClass();
            PointNew.X = 2;
            PointNew.Y = 4;
            PointClass PointNew2 = new PointClass();
            PointNew2.X = 12;
            PointNew2.Y = 13;
            PointClass.PointDistance(PointNew, PointNew2);
        }

        [Benchmark]
        public void TestPointStruct()
        {
            PointStruct PointNew = new PointStruct();
            PointNew.X = 2;
            PointNew.Y = 4;
            PointStruct PointNew2 = new PointStruct();
            PointNew2.X = 12;
            PointNew2.Y = 13;
            PointStruct.PointDistance(PointNew, PointNew2);
        }
        [Benchmark]
        public void TestPointStructDouble()
        {
            PointStruct PointNew = new PointStruct();
            PointNew.X = 2;
            PointNew.Y = 4;
            PointStruct PointNew2 = new PointStruct();
            PointNew2.X = 12;
            PointNew2.Y = 13;
            PointStruct.PointDistanceDouble(PointNew, PointNew2);
        }
        [Benchmark]
        public void TestPointStructShort()
        {
            PointStruct PointNew = new PointStruct();
            PointNew.X = 2;
            PointNew.Y = 4;
            PointStruct PointNew2 = new PointStruct();
            PointNew2.X = 12;
            PointNew2.Y = 13;
            PointStruct.PointDistanceShort(PointNew, PointNew2);
        }
    }

}
