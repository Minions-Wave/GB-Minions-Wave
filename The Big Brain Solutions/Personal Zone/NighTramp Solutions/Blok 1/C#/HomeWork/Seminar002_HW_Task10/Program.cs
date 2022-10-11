/*
Задача 10: Напишите программу, которая принимает на вход 
трёхзначное число и на выходе показывает вторую цифру этого 
числа.
456 -> 5
782 -> 8
918 -> 1
*/
namespace Task10
{
    class Program
    {
        public static void SecondNumberView(int number)
        {
            Console.Write((number / 10) % 10);
        }
        static void Main(string[] asgs)
        {
            SecondNumberView(Convert.ToInt32(Console.ReadLine()));
        }
    }
}