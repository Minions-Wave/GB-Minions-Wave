// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

namespace GB.CSharp.Seminar9
{
    class task1
    {
        public static void Main(string[] args)
        {
            int row = new Random().Next(3,6);
            int column = new Random().Next(3,6);
            int[,] matrix = new int[row, column];
            FillArray(matrix);
            PrintArray(matrix);
            Console.WriteLine();
            int[,] matrix2 = GetEvenPositionSquares(matrix);
            PrintArray(matrix2);
        }

        public static int[,] FillArray(int[,] matr)
        {
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    matr[i, j] = new Random().Next(1, 9);
                }
            }
            return matr;
        }

        public static int[,] PrintArray(int[,] matr)
        {
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    Console.Write(matr[i, j] + " | ");
                }
                Console.WriteLine();
            }
            return matr;
        }

        public static int [,] GetEvenPositionSquares(int [,] matrixES)
        {
            for(int i = 0; i < matrixES.GetLength(0); i++)
            {
                for(int j = 0; j < matrixES.GetLength(1); j++)
                {
                    if(i%2==0 && j%2==0)
                    {
                        matrixES[i,j] = matrixES[i,j] * matrixES[i,j];
                    }
                }
            }
            return matrixES;
        }
        
    }
}
