// Задача 58: Задайте две матрицы.
// Напишите программу, которая выведет
// матрицу произведения элементов двух предыдущих матриц.

// Например, заданы 2 массива:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// и

// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

// Их произведение будет равно следующему массиву:

// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

namespace DZ58
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
            int[,] arrayMxN1 = new int[lines, columns];
            int[,] arrayMxN2 = new int[lines, columns];
            int[,] multOfarraysMxN = new int[lines, columns];

            FillArray(arrayMxN1);
            Console.WriteLine("Первый массив");
            PrintArray(arrayMxN1);
            Console.WriteLine();
            FillArray(arrayMxN2);
            Console.WriteLine("Второй массив");
            PrintArray(arrayMxN2);
            Console.WriteLine();
            MultiplyArrays(arrayMxN1, arrayMxN2, multOfarraysMxN);
            Console.WriteLine("Произведение массивов");
            PrintArray(multOfarraysMxN);
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

        public static void PrintArray(int[,] someArray)
        {
            for (int i = 0; i < someArray.GetLength(0); i++)
            {
                for (int j = 0; j < someArray.GetLength(1); j++)
                {
                    Console.Write("{0,6}", someArray[i, j]);
                }
                Console.WriteLine();
            }
        }

        public static void MultiplyArrays(int[,] someArray, int[,] someArray2, int[,] multArray)
        {

            for (int i = 0; i < someArray.GetLength(0); i++)
            {
                for (int j = 0; j < someArray.GetLength(1); j++)
                {
                    multArray[i, j] = someArray[i, j] * someArray2[i, j];
                }
            }
        }

    }
}