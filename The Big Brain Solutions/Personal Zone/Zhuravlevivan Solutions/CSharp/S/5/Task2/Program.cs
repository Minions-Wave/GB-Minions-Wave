// 2. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да
// Размер массива от 5 до 10
// Числа в массива от -20 до 20

namespace S5T2
{
    class Program
    {
        public static void Main()
        {

            // Console.Write("Введите размер массива: ");
            // int a = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[new Random().Next(5, 11)];


            Console.Write("Введите число для проверки, присутствует ли оно в массиве: ");
            int digit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Fill(arr);
            PrintArray(arr);
            Console.WriteLine();
            if ((Check(arr, digit)) == true)
            {
                Console.WriteLine("\nДа!");
            }
            else
            {
                Console.WriteLine("\nНет");
            }

        }

        public static void PrintArray(int[] ar)
        {
            for (int i = 0; i < ar.Length; i++)
            {
                Console.Write($"{ar[i]} ");
            }
        }

        public static bool Check(int[] ar, int dig)
        {
            for (int i = 0; i < ar.Length; i++)
            {
                if (dig == ar[i])
                {
                    return true;
                }
            }
            return false;
        }

        public static void Fill(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = new Random().Next(-20, 20);
            }
        }




    }

}