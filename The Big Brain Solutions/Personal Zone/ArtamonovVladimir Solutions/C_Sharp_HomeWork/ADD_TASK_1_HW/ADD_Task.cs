// // Задача Дополнительная: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// Console.WriteLine("Введите трехзначное или любое другое чиcло: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int result = number % 10;
// Console.WriteLine($"Последняя цифра в Вашем числе составляет {result}");

// int n = Convert.ToInt32.Console.WriteLine(new Random().Next(1,111));
// new[] array =  string[3];
//  number[0] = array[0];
// int[1] = array[2];
// Console.WriteLine(number)
 namespace VladimirArtamnov
 {
    class HomeWork
    {
        public static int GetRandomNumber(int first, int second)
        {
            int randomNumber = new Random().Next(first, second);
            return randomNumber;
        }
        
        public static void Main(string[] args)
        {
        // Задача Дополнительная: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
         // Вариант решения 1
         Console.WriteLine("Введите трехзначное или любое другое чиcло: ");
         int number = Convert.ToInt32(Console.ReadLine());
         int result = number % 10;
         Console.WriteLine($"Последняя цифра в Вашем числе составляет {result}");
        // Вариант решения 2
        Console.WriteLine(Convert.ToInt32(Console.ReadLine()) % 10);
        // Вариант решения 3
        string? str = Console.ReadLine();
        if (str != null)
        {
            string strFinal = Convert.ToString(str);
            Console.WriteLine(strFinal[strFinal.Length - 1]);
        }
        else
        {
            Console.WriteLine("Строка null - Ошибка");
        }
        // Вариант решения 4 (от преподавателя)
        Console.WriteLine(Console.ReadLine().ToString().ToCharArray().LastOrDefault());
        }
    }
 }