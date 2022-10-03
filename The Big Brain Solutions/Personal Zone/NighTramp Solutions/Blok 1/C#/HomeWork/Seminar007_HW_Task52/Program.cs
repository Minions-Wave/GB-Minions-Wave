/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
namespace Task52
{
    class Program
    {
        static int[,] array = {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}};
        static float[] average_array = new float[array.GetUpperBound(1) + 1];
        static void FindAverageOfColumnsOf2DArray()
        {
            for (int j = 0; j <= array.GetUpperBound(1); j++)
            {
                int i;
                for (i = 0; i <= array.GetUpperBound(0); i++)
                {
                    average_array[j] += array[i,j];
                }
                average_array[j] = average_array[j] / (i);
            }
        }
        static void ViewAverage()
        {
            Console.Write("Среднее арифметическое каждого столбца: ");
            for (int i = 0; i < average_array.Length; i++)
            {
                Console.Write("{0}; ", Math.Round(average_array[i], 1));
            }
        }
        static void Main(string[] asgs)
        {
            FindAverageOfColumnsOf2DArray();
            ViewAverage();
        }
    }
}