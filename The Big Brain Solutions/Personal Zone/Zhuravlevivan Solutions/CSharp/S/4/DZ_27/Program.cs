// Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

namespace DZ_27
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Введите число: ");
            int digit = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
           
            while (digit != 0)
            {
                sum = sum + digit % 10;
                digit = digit / 10;
            }
            Console.Write($"Сумма цифр числа равна: {sum}");
            
        }
    }
}