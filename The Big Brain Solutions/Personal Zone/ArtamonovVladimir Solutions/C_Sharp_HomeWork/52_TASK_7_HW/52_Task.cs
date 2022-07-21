namespace VladimirArtamnov
{
    public static class HomeWork_Task_52
    {
        //Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
        //Например, задан массив:
        //1 4 7 2
        //5 9 2 3
        //8 4 2 4
        //Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

        public static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк в массиве:");
            int rowLength = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество колонок в массиве:");
            int columnLength = Convert.ToInt32(Console.ReadLine());
            int[,] twoDimensionalArray = new int[rowLength, columnLength];
            List<double> averageNumberList = new List<double>();
            RandomFillTwoDimensionalArray(twoDimensionalArray);
            PrintArray(twoDimensionalArray);
            AverageNumberByColumnCalculation(twoDimensionalArray, averageNumberList);
            Console.WriteLine("Среднее арифметическое каждого столбца:");
            foreach (double average in averageNumberList)
            {
                Console.Write($"{average:#.#}; ");
            }
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

        public static void AverageNumberByColumnCalculation(int[,] array, List<double> list)
        {
            for (int i = 0; i < array.GetLength(1); i++)
            {
                double sumByColumn = 0;
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    sumByColumn += array[j, i];
                }
                list.Add(Convert.ToDouble(sumByColumn / array.GetLength(0)));
            }
        }

    }
}
