namespace VladimirArtamnov
{
    public static class HomeWorkTask56
    {
        //Задача 56. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
        //Например, задан массив:
        //1 4 7 2
        //5 9 2 3
        //8 4 2 4
        //5 2 6 7
        //Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

        public static void Main(string[] args)
        {
            Console.WriteLine("Вы должны задать прямоугольный массив, если ошибетесь, то будете вводить заново!");
            bool checkRectangle = true;
            int rowLength = 1,
                columnLength = 1;
            while (checkRectangle)
            {
                Console.WriteLine("Введите количество строк в массиве:");
                rowLength = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите количество колонок в массиве:");
                columnLength = Convert.ToInt32(Console.ReadLine());
                if (rowLength > columnLength || rowLength < columnLength)
                {
                    checkRectangle = false;
                }
            }
            int[,] twoDimensionalArray = new int[rowLength, columnLength];
            RandomFillTwoDimensionalArray(twoDimensionalArray);
            Console.WriteLine("Массив:");
            PrintArray(twoDimensionalArray);
            List<int> sumByRowList = new List<int>();
            SumByRowCalculation(twoDimensionalArray, sumByRowList);
            int numberOfRow = sumByRowList.IndexOf(sumByRowList.Min());
            Console.WriteLine($"Hомер строки с наименьшей суммой элементов: {numberOfRow + 1}");
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

        public static void SumByRowCalculation(int[,] array, List<int> list)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                double sumByRow = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sumByRow += array[i, j];
                }
                list.Add(Convert.ToInt32(sumByRow));
            }
        }

    }
}
