/*
Задача 54: Задайте двумерный массив. Напишите программу, которая
 упорядочит по возрастанию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
1 2 4 7
2 3 5 9
2 4 4 8
*/
namespace Task54
{
    class Program
    {
        static int[,] _array = {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}};
        static void ViewTwoDimensionalArray(int[,] array)
        {
            for (int i = 0; i <= array.GetUpperBound(0); i++) //row
            {
                Console.Write("[ ");
                for (int j = 0; j <= array.GetUpperBound(1); j++) //columns
                {
                    Console.Write("{0} ", array[i,j]);
                }
                Console.WriteLine("]");
            }
        }
        static int[,] ArrayRowAscendingSort(int[,] array)
        {
            for (int i = 0; i <= array.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= array.GetUpperBound(1); j++)
                {
                    for (int k = j + 1; k <= array.GetUpperBound(1); k++)
                    {
                        if (array[i,j] > array[i,k])
                        {
                            int temp = array[i,j];
                            array[i,j] = array[i,k];
                            array[i,k] = temp;
                        }
                    }
                }
            }
            return array;
        }
        static void Main(string[] asgs)
        {
            Console.WriteLine("Например, задан массив:");
            ViewTwoDimensionalArray(_array);
            Console.WriteLine("В итоге получается вот такой массив:");
            _array = ArrayRowAscendingSort(_array);
            ViewTwoDimensionalArray(_array);
        }
    }
}