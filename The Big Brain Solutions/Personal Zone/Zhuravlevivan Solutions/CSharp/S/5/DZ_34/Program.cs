// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

namespace DZ_34
{
    class Program
    {
        public static void Main()
        {

            int[] three_arr = new int[21];
            Fill(three_arr);
            PrintArray(three_arr);
            Console.WriteLine();
            EvenCheck(three_arr);
        }

        public static void Fill(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = new Random().Next(100, 1000);
            }
        }

        public static void EvenCheck(int[] arr)
        {
            int count = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    // Console.Write($"{arr[i]} ");
                    count++;
                }
            }
            Console.WriteLine($"Количество чётных чисел в массиве: {count}");
        }

        public static void PrintArray(int[] ar)
        {
            for (int i = 0; i < ar.Length; i++)
            {
                Console.Write($"{ar[i]} ");
            }
        }
    }
}