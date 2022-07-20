/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки 
с наименьшей суммой элементов: 1 строка
*/
namespace Task56
{
    class Program
    {
        static int[,] _array = {{1, 4, 7, 2}, 
                                {5, 9, 2, 3}, 
                                {8, 4, 2, 4},
                                {5, 2, 6, 7}};
        static int[] _sumRowElem = new int[_array.GetLength(0)];
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
        static int[] ArrayRowSumOfElem(int[,] array, int[] sumRowElem)
        {
            for (int i = 0; i <= array.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= array.GetUpperBound(1); j++)
                {
                    sumRowElem[i] += array[i,j];
                }
            }
            return sumRowElem;
        }
        static int SearchMinElemArray(int[] array)
        {
            int min_index = -1;
            if (array.Length > 0)
                min_index = 0;
                if (array.Length > 1) 
                    for (int i = 1; i < array.Length; i++)
                    {
                        if (array[min_index] > array[i]) min_index = i;
                    }
            return min_index;
        }
        static void Main(string[] asgs)
        {
            Console.WriteLine("Например, задан массив:");
            ViewTwoDimensionalArray(_array);
            Console.WriteLine("номер строки с наименьшей суммой элементов: {0} строка", 
                              SearchMinElemArray(ArrayRowSumOfElem(_array,_sumRowElem)) + 1);
        }
    }
}