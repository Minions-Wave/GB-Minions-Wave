// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using GBhomework7;

namespace GBhomework7
{
    class Task52
    {
        Text task52 = new();
        Methods method = new(); 
        public void GetTask52()
        {
            task52.task3main();
            double [,] matrix = new double [3,4];
            method.FillMatrix(matrix);
            method.PrintMatrix(matrix);
            method.GetColumnAverage(matrix);
        }
    }
}