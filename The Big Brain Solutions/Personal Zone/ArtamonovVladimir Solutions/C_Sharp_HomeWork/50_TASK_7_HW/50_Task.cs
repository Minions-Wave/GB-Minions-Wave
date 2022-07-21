namespace VladimirArtamnov
{
    public static class HomeWork_Task_50
    {
        //Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
        //и возвращает значение этого элемента или же указание, что такого элемента нет. 
        //Например, задан массив:
        //1 4 7 2
        //5 9 2 3
        //8 4 2 4
        //17 -> такого числа в массиве нет

        public static void Main(string[] args)
        {
            int rowLength = new Random().Next(1, 10);
            int columnLength = new Random().Next(1, 10);
            Console.WriteLine("Введите позицию элемента по строке:");
            int rowIndex = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите позицию элемента по колонке:");
            int columnIndex = Convert.ToInt32(Console.ReadLine());
            if (rowIndex > rowLength - 1 || columnIndex > columnLength - 1)
            {
                Console.Write($"В массиве {rowLength} на {columnLength}. ");
                Console.WriteLine("Такого элемента нет!!!");
            }
            else
            {
                double[,] twoDimensionalArray = new double[rowLength, columnLength];
                RandomFillTwoDimensionalArray(twoDimensionalArray);
                PrintArray(twoDimensionalArray);
                Console.WriteLine($"Элемент на позиции {rowIndex}, {columnIndex} равен {twoDimensionalArray[rowIndex, columnIndex]:#.##}");
            }
        }

        public static void RandomFillTwoDimensionalArray(double[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().NextDouble() * new Random().Next(-100, 100);
                }
            }
        }

        public static void PrintArray(double[,] incomingArray)
        {
            for (int i = 0; i < incomingArray.GetLength(0); i++)
            {
                for (int j = 0; j < incomingArray.GetLength(1); j++)
                {
                    //Console.Write($"{incomingArray[i, j]:#.##} ");
                    Console.Write($"{Math.Round(incomingArray[i, j], 2)} ");
                }
                Console.WriteLine();
            }
        }

    }
}
