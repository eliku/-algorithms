using System;


namespace Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            int N = rand.Next(20);
            int M = rand.Next(20);
            int[,] A = new int[N, M];
            int i, j;
            for (j = 0; j < M; j++)
                A[0, j] = 1; // Первая строка заполнена единицами
            for (i = 1; i < N; i++)
            {
                A[i, 0] = 1;
                for (j = 1; j < M; j++)
                    A[i, j] = A[i, j - 1] + A[i - 1, j];
            }
            Console.WriteLine($"Матрица {N} на {M} ");
            Console.WriteLine($"{A[N-1, M-1]} различных маршрутов, ведущих из левого верхнего угла в правый нижний.");
        }
    }

}
