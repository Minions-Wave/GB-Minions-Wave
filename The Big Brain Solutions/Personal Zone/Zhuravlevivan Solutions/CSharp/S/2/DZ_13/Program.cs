// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

namespace GeekBrains
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            string? d = Console.ReadLine();
            
            if(d?.Length < 3)
            {
                Console.WriteLine("Третьей цифры нет");
            }
            if(d?.Length >= 3)
            {
                char thirdChar = d[2];
                Console.WriteLine($"Третья цифра числа: {thirdChar}");
            }
            
        }
        
    }
}