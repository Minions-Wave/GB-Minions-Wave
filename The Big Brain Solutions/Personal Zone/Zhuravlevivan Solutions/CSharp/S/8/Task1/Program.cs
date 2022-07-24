// 1. Задайте двумерный массив.
// Напишите программу, которая поменяет местами
// первую и последнюю строку массива.
// Например, задан массив: 
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 8 4 2 4
// 5 9 2 3
// 1 4 7 2

namespace S8Task1
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("\nПрограмма поменяет местами первую и последние строки массива");
            Console.WriteLine("\nЗадайте размер массива");
            Console.Write("Количество строк: ");
            int lines = Convert.ToInt32(Console.ReadLine());
            Console.Write("Количество столбцов: ");
            int columns = Convert.ToInt32(Console.ReadLine());
            int[,] array2d = new int[lines, columns];
            int[,] tempArray = new int[lines, columns];

            FillArray(array2d);
            PrintArray(array2d);
            ChangeLinesArray(array2d, tempArray);
            Console.WriteLine();
            PrintArray(tempArray);
        }

        public static void FillArray(int[,] someArray)
        {
            for (int i = 0; i < someArray.GetLength(0); i++)
            {
                for (int j = 0; j < someArray.GetLength(1); j++)
                {
                    someArray[i, j] = new Random().Next(100);
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

        public static void ChangeLinesArray(int[,] some2dArray, int[,] tmpArray)
        {
            for (int i = 0; i < some2dArray.GetLength(0); i++)
            {
                for (int j = 0; j < some2dArray.GetLength(1); j++)
                {
                    if (i == 0)
                    {
                        tmpArray[tmpArray.GetLength(0) - 1, j] = some2dArray[i, j];
                    }
                    else if (i == some2dArray.GetLength(0) - 1)
                    {
                        tmpArray[0, j] = some2dArray[some2dArray.GetLength(0) - 1, j];
                    }
                    else
                    {
                        tmpArray[i, j] = some2dArray[i, j];
                    }
                }
            }
        }
    }
}
