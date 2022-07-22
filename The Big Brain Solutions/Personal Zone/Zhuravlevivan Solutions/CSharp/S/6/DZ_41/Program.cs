// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


namespace DZ41
{
    class Program
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("Программа покажет, сколько введено чисел больше нуля");
                Console.Write("Введите числа через пробел: ");
                int[] arr_m = Console.ReadLine().Split().Select(int.Parse).ToArray();
                CheckDigit(arr_m);

            }

            catch (FormatException)
            {
                Console.WriteLine("Введен некорректный символ");
                Main();
            }
        }

        // Считаем сумму элементов массива больше нуля
        public static void CheckDigit(int[] check_arr)
        {
            int count = 0;
            for (int i = 0; i < check_arr.Length; i++)
            {
                if (check_arr[i] > 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"Количество введенных чисел больше нуля: {count}");
        }
    }
}