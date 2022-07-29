// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

namespace DZ50
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
            FillAndPrintArray(arrayMxN);
            Console.WriteLine("--------------------");
            ArithmeticMean(arrayMxN);
            Console.WriteLine();
        }

        public static void FillAndPrintArray(int[,] someArray)
        {
            Random random = new Random();
            for (int i = 0; i < someArray.GetLength(0); i++)
            {
                for (int j = 0; j < someArray.GetLength(1); j++)
                {
                    someArray[i, j] = random.Next(100);
                    Console.Write("{0,4}", someArray[i, j]);
                }
                Console.WriteLine();
            }
        }
        public static void ArithmeticMean(int[,] someArray)
        {
            double mean = 0;
            double[] arrMean = new double[someArray.GetLength(1)];
            for (int i = 0; i < someArray.GetLength(1); i++)
            {

                for (int j = 0; j < someArray.GetLength(0); j++)
                {
                    mean = mean + someArray[j, i];
                }
                arrMean[i] = mean / someArray.GetLength(1);
            }
            Print(arrMean);
        }
        public static void Print(double[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"{Math.Round(nums[i], 1)} ");
            }
            Console.Write(" : Среднее арифметическое каждого столбца");
        }
    }
}
