// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

namespace DZ_36
{
    class Program
    {
        public static void Main()
        {

            int[] three_arr = new int[new Random().Next(5, 21)];
            Fill(three_arr);
            Console.WriteLine();
            PrintArray(three_arr);
            Console.WriteLine();
            OddPosition(three_arr);

        }

        public static void Fill(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = new Random().Next(0, 100);
            }
        }

        public static void OddPosition(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sum = sum + arr[i];
                    Console.WriteLine($"DigitOnIndex {i} = {arr[i]}");
                }
            }
            Console.WriteLine($"Sum of digit in odd position: {sum}");
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