// 2. Задайте двумерный массив.
// Найдите сумму элементов, находящихся на главной диагонали
// (с индексами (0,0); (1; 1) и т.д.
// Например, задан массив: 
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12 

namespace S7T1
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
            int[] sumDiag = new int[Math.Min(lines, columns)]; // инициализация массива для диагонали

            FillArray(arrayMxN);
            Print2Darray(arrayMxN);
            Console.WriteLine();
            SumMainDiag(arrayMxN, sumDiag);
            Print1Darray(sumDiag);
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

        public static void Print2Darray(int[,] someArray)
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

        public static void Print1Darray(int[] someArray)
        {
            Console.WriteLine("Сумма элементов главной диагонали: {0} = {1}\n", string.Join(" + ", someArray), someArray.Sum());
        }
        public static void SumMainDiag(int[,] someArray, int[] sum)
        {
            for (int i = 0, j = 0; i < sum.Length; i++, j++)
            {
                sum[i] += someArray[i, j];
            }
        }
    }
}