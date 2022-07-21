// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:

// 1  2  3  4
// 12 13 14 5
// 11 16 15 6
// 10 9  8  7

namespace Geekbrains
{
    static public class HWE62
    {
        static public void Main()
        {
            Console.Write("Введите ширину массива:");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите высоту массива:");
            int height = Convert.ToInt32(Console.ReadLine());

            int val = 0;
            int[,] arr = new int[width, height];

            Console.WriteLine();

            Circus(arr, val, 0, arr.GetLength(0), arr.GetLength(1));
            PrintArray(arr);

            Console.WriteLine();
        }
        public static void Circus(int[,] x, int value, int start, int length0, int length1)
        {
            if (start < length0 - 1 && start < length1 - 1)
            {
                for (int j = start, i = start; j < length1; j++)
                {
                    x[i, j] = value++;
                }

                for (int i = start + 1, j = length1 - 1; i < length0; i++)
                {
                    x[i, j] = value++;
                }

                for (int j = length1 - 2, i = length0 - 1; j >= start; j--)
                {
                    x[i, j] = value++;
                }

                for (int i = length0 - 2, j = start; i > start; i--)
                {
                    x[i, j] = value++;
                }

                Circus(x, value, start + 1, length0 - 1, length1 - 1);

            }

            else if (start == length0 - 1 && length0 == length1)
            {
                x[start, start] = value;
            }

            else if (start == length0 - 1 && length0 < length1)
            {
                x[start, start] = value++;
                for (int i = 0; i <= length1 - length0; i++)
                {
                    x[start, start + i] = value++;
                }
            }

            else if (start == length1 - 1 && length0 > length1)
            {
                x[start, start] = value++;
                for (int i = 0; i <= length0 - length1; i++)
                {
                    x[start + i, start] = value++;
                }
            }

            else return;

        }

        public static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine();
                Console.Write("  ");
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(string.Format("{0,3} ", array[i, j])); // Выравнивание по 5 символам
                }
                //Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
