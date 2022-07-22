// 1.Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Aₘₙ = m + n.

// Выведите полученный массив на экран. m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5 

namespace S7T1
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Введите размерность двумерного массива через пробел: ");
            string[] arr = Console.ReadLine().Split();

            int a = int.Parse(arr[0]);
            int b = int.Parse(arr[1]);
            int[,] numbers = new int[a, b];

            ArrayAmn(numbers);
            PrintArray(numbers);
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

        public static void ArrayAmn(int[,] someArray)
        {
            for (int i = 0; i < someArray.GetLength(0); i++)
            {
                for (int j = 0; j < someArray.GetLength(1); j++)
                {
                    someArray[i, j] = i + j;
                }
            }
        }
    }
}