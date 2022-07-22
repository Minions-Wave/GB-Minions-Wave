// Задача 50. Напишите программу, которая на
// вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
namespace DZ50
{
    class Program
    {
        public static void Main()
        {
            try
            {
                Console.Write("Введите строку и столбец искомого числа в массиве (через пробел): ");
                int[] arrPosition = Console.ReadLine()
                                    .Split()
                                    .Select(int.Parse)
                                    .ToArray();

                int a = arrPosition[0] - 1;
                int b = arrPosition[1] - 1;

                int random = new Random().Next(9);
                int[,] array2d = new int[random, random];
                FillArray(array2d);
                Console.WriteLine("Случайный массив:");
                PrintArray(array2d);
                Console.WriteLine();
                CheckElementPosition(array2d, a, b);

            }
            catch (System.FormatException)
            {
                Console.WriteLine("Введены лишние или некорректные символы");
                Main();
            }
        }
        public static void CheckElementPosition(int[,] someArray, int y, int x)
        {
            if (y <= someArray.GetLength(0) && x <= someArray.GetLength(1))
            {
                Console.WriteLine($"На позиции [Строка: {y + 1}, Столбец: {x + 1}] находится число {someArray[y, x]}");
            }
            else
            {
                Console.WriteLine("Такого числа в массиве нет");
            }
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
    }
}