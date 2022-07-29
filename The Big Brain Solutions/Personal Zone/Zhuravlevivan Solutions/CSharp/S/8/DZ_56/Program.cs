// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

namespace DZ56
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("\nЗадайте размер массива");
            Console.Write("Количество строк: ");
            int lines = Convert.ToInt32(Console.ReadLine());
            Console.Write("Количество столбцов: ");
            int columns = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int[,] arrayMxN = new int[lines, columns];
            FillArray(arrayMxN);
            PrintArray(arrayMxN);
            Console.WriteLine();
            FindMinLine(arrayMxN);
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

        public static void FindMinLine(int[,] someArray)
        {
            int[] sum = new int[someArray.GetLength(0)];
            for (int i = 0; i < someArray.GetLength(0); i++)
            {
                for (int j = 0; j < someArray.GetLength(1); j++)
                {
                    sum[i] += someArray[i, j];
                }
            }
            Console.WriteLine($"Номер строки с наименьшей суммой элементов: {Array.IndexOf(sum, sum.Min()) + 1}\n");
        }
    }
}