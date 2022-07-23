// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: 
// Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.

// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

namespace GB.CSharp.Seminar7
{
    class task1
    {
        public static void Main(string[] args)
        {
            int m = 3;
            int n = 4;
            int [,] array = new int [m,n];
            Console.WriteLine($"Сгенерирован следующий массив размера [3,4]: ");
            PrintArray(FillArray(array, m, n), m, n);
            

        }

        public static int [,] FillArray(int [,] arrayX, int M, int N)
        {
            for(int i = 0; i < M; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    arrayX[i,j] = i+j;
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
    }
}
