namespace VladimirArtamnov
{
    public static class HomeWorkTask58
    {
        //Задача 58. Задайте две матрицы. Напишите программу, которая выведет матрицу произведения элементов двух предыдущих матриц.
        //Например, заданы 2 массива:
        //1 4 7 2
        //5 9 2 3
        //8 4 2 4
        //5 2 6 7
        //и
        //1 5 8 5
        //4 9 4 2
        //7 2 2 6
        //2 3 4 7
        //Их произведение будет равно следующему массиву:
        //1 20 56 10
        //20 81 8 6
        //56 8 4 24
        //10 6 24 49

        public static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк в матрицах:");
            int rowLength = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество колонок в матрицах:");
            int columnLength = Convert.ToInt32(Console.ReadLine());
            int[,] firstTwoDimensionalArray = new int[rowLength, columnLength];
            int[,] secondTwoDimensionalArray = new int[rowLength, columnLength];
            RandomFillTwoDimensionalArray(firstTwoDimensionalArray);
            Console.WriteLine("Первая матрица:");
            PrintArray(firstTwoDimensionalArray);
            RandomFillTwoDimensionalArray(secondTwoDimensionalArray);
            Console.WriteLine("Вторая матрица:");
            PrintArray(secondTwoDimensionalArray);
            int[,] finalTwoDimensionalArrayOfFirstMultiplySecond = MultiplyFirstAndSecondArrayByIndex(firstTwoDimensionalArray, secondTwoDimensionalArray);
            Console.WriteLine("Матрица произведения элементов двух предыдущих матриц: ");
            PrintArray(finalTwoDimensionalArrayOfFirstMultiplySecond);
        }

        public static void RandomFillTwoDimensionalArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(1, 10);
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

        public static int[,] MultiplyFirstAndSecondArrayByIndex(int[,] firstArray, int[,] secondArray)
        {
            int[,] finalArray = new int[firstArray.GetLength(0), firstArray.GetLength(1)];
            for (int i = 0; i < finalArray.GetLength(0); i++)
            {
                for (int j = 0; j < finalArray.GetLength(1); j++)
                {
                    finalArray[i, j] = firstArray[i, j] * secondArray[i, j];
                }
            }
            return finalArray;
        }

    }
}
