// Задача 19
// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

namespace GeekBrains
{
    class Program
    {
        public static void Main(string[] args)
        {

        Console.Write("Введите 5-ти значное число: "); 
        string? d = Console.ReadLine();

        if (d[0] == d[^1] && d[1] == d[^2])
        {
            Console.WriteLine("Это палиндром");
        }
        else
        {
            Console.WriteLine("Это не палиндром");
        }
            
        }
       
    }
}