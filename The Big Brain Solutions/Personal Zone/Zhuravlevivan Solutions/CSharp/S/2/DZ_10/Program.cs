/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число
и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

// Решение #1
// Вывод значения индекса массива

/*
namespace GeekBrains
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите трёхзначное число: ");
            int d = Convert.ToInt32(Console.ReadLine());
            char[] c = d.ToString().ToCharArray(); 
                    // Создаем пустой чар-массив "с" и записываем в него число "d".
                    // Конвертируем в строку. Затем в чар-массив
                    
            char[] b = {c[1]}; 
                
                    // Создаем пустой чар-массив "d" и записываем в него значения индексов массива "c".
                    // У нас там содержится трехзначное число.
                    // Согласно заданию выводим вторую цифру.
                
            Console.WriteLine(b);
            
        }
        
    }
}

*/

// Решение #2
// Целочисленное деление, и остаток от деления    

namespace GeekBrains
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите трёхзначное число: ");
            int d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Вторая цифра: {((d / 10) % 10)}");
            
        }
        
    }
}