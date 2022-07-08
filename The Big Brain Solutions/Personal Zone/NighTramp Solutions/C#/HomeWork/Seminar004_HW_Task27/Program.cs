/*
Задача 27: Напишите программу, которая принимает на вход 
число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
namespace Task27
{
    class Program
    {
        static void ViewSumOfDigitsOfNumber(int number)
        {
            number = Math.Abs(number);
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            Console.WriteLine(sum);
        }
        static void Main(string[] asgs)
        {
            ViewSumOfDigitsOfNumber(Convert.ToInt32(Console.ReadLine()));
        }
    }
}