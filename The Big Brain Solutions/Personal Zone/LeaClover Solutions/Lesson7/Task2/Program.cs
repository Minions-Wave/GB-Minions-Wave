// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали 
// (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

namespace GB.CSharp.Seminar7
{
    class task2
    {
        public static void Main(string[] args)
        {
            int m = 3;
            int n = 4;
            int [,] array = new int [m,n];
            Console.WriteLine($"Сгенерирован следующий массив размера [3,4]: ");
            PrintArray(FillArray(array, m, n), m, n);
            Console.WriteLine($"Сумма элементов на главной диагонали массива равна {GetSumDiagonal(array, m, n)}");
        }

        public static int [,] FillArray(int [,] arrayX, int M, int N)
        {
            for(int i = 0; i < M; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    arrayX[i,j] = new Random().Next(1, 11);
                }
            }
            return arrayX;
        }

        public static int [,] PrintArray(int [,] arrayP, int M, int N)
        {
            for(int i = 0; i < M; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    Console.Write(arrayP[i,j] + " ");
                }
            Console.WriteLine();
            }
            return arrayP;
        }

        public static int GetSumDiagonal(int [,] arrayX, int M, int N)
        {
            int sum = 0;
            for(int i = 0; i < M; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    if(i==j)
                    {
                        sum = sum + arrayX[i,j];
                    }
                }
            }
            return sum;
        }
    }
}
