// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

using GBhomework7;

namespace GBhomework7
{
    class Task47
    {
        public void GetTask47()
        {
            Text task47 = new();
            Methods method = new();
            task47.task1main();
            double[,] matrix = new double[3, 4];
            method.FillMatrix(matrix);
            method.PrintMatrix(matrix);
        }
    }
}