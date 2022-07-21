namespace VladimirArtamnov
{
    public static class HomeWork_Task_54
    {
        //Задача 54. Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
        //Например, задан массив:
        //1 4 7 2
        //5 9 2 3
        //8 4 2 4
        //В итоге получается вот такой массив:
        //1 2 4 7
        //2 3 5 9
        //2 4 4 8

        public static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк в массиве:");
            int rowLength = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество колонок в массиве:");
            int columnLength = Convert.ToInt32(Console.ReadLine());
            int[,] twoDimensionalArray = new int[rowLength, columnLength];
            RandomFillTwoDimensionalArray(twoDimensionalArray);
            Console.WriteLine("Входной массив:");
            PrintArray(twoDimensionalArray);
            SortedArrayByRow(twoDimensionalArray);
            Console.WriteLine("Упорядоченный по возрастанию элементов в строках массив:");
            PrintArray(twoDimensionalArray);
        }

        public static void RandomFillTwoDimensionalArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(1, 100);
                }
            }
        }

        public static void PrintArray(int[,] incomingArray)
        {
            for (int i = 0; i < incomingArray.GetLength(0); i++)
            {
                for (int j = 0; j < incomingArray.GetLength(1); j++)
                {
                    Console.Write($"{incomingArray[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public static void SortedArrayByRow(int[,] array)
        {
            int minElementColumnIndex,
                maxElementColumnIndex,
                tempVariable;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int k = 0; k < array.GetLength(1) / 2; k++)
                {
                    //Console.WriteLine($"k = {k}");
                    minElementColumnIndex = k;
                    maxElementColumnIndex = k;
                    for (int j = 1 + k; j < array.GetLength(1) - k; j++)
                    {
                        if (array[i, j] < array[i, minElementColumnIndex])
                        {
                            minElementColumnIndex = j;
                            //Console.WriteLine($"min = {j}");
                        }
                        if (array[i, j] > array[i, maxElementColumnIndex])
                        {
                            maxElementColumnIndex = j;
                            //Console.WriteLine($"max = {j}");
                        }
                    }
                    tempVariable = array[i, array.GetLength(1) - 1 - k];
                    array[i, array.GetLength(1) - 1 - k] = array[i, maxElementColumnIndex];
                    if (minElementColumnIndex == array.GetLength(1) - 1 - k)
                    {
                        minElementColumnIndex = maxElementColumnIndex;
                    }
                    array[i, maxElementColumnIndex] = tempVariable;
                    tempVariable = array[i, k];
                    array[i, k] = array[i, minElementColumnIndex];
                    array[i, minElementColumnIndex] = tempVariable;

                    //PrintArray(array);
                }
            }
        }

    }
}
