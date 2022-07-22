// Задача 54: Задайте двумерный массив.
// Напишите программу, которая упорядочит по возрастанию
// элементы каждой строки двумерного массива.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:

// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

namespace DZ54
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Задайте размер массива");
            Console.Write("Количество строк: ");
            int lines = Convert.ToInt32(Console.ReadLine());
            Console.Write("Количество столбцов: ");
            int columns = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int[,] arrayMxN = new int[lines, columns];

            FillArray(arrayMxN);
            Console.WriteLine("Массив до сортировки строк:\n");
            PrintArray(arrayMxN);
            Console.WriteLine();
            SortArrayMinMax(arrayMxN);
            Console.WriteLine("Строки отсортированы по возрастанию:\n");
            PrintArray(arrayMxN);
        }

        public static void FillArray(int[,] someArray)
        {
            Random random = new Random();
            for (int i = 0; i < someArray.GetLength(0); i++)
            {
                for (int j = 0; j < someArray.GetLength(1); j++)
                {
                    someArray[i, j] = random.Next(100);
                }
            }
        }
        public static void PrintArray(int[,] someArray)
        {
            for (int i = 0; i < someArray.GetLength(0); i++)
            {
                for (int j = 0; j < someArray.GetLength(1); j++)
                {
                    Console.Write("{0,4}", someArray[i, j]);
                }
                Console.WriteLine();
            }
        }
        public static void SortArrayMinMax(int[,] someArray)
        {
            for (int i = 0; i < someArray.GetLength(0); i++)
            {
                for (int j = 0; j < someArray.GetLength(1); j++)
                {
                    for (int k = 0; k < someArray.GetLength(1); k++)
                    {
                        if (someArray[i, k] <= someArray[i, j]) continue;
                        {
                            int tmp = someArray[i, k];
                            someArray[i, k] = someArray[i, j];
                            someArray[i, j] = tmp;
                        }
                    }
                }
            }
        }
    }
}