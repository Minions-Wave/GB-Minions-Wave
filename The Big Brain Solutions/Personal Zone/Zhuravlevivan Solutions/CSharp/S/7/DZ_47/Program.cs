// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

namespace S7DZ_47
{
    class Program
    {
        public static void Main()
        {
            Console.Clear();
            Console.WriteLine("Задайте размер массива");
            Console.Write("Количество строк: ");
            int lines = Convert.ToInt32(Console.ReadLine());
            Console.Write("Количество столбцов: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            double[,] arrayMxN = new double[lines, columns];
            FillAndPrintArray(arrayMxN);
        }

        public static void FillAndPrintArray(double[,] someArray)
        {
            Random random = new Random();
            for (int i = 0; i < someArray.GetLength(0); i++)
            {
                for (int j = 0; j < someArray.GetLength(1); j++)
                {
                    someArray[i, j] = random.NextDouble() * 100;
                    Console.Write("{0,6:F2}", someArray[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}