/* Задача 2. Напишите программу, которая по заданному номеру четверти,
показывает диапазон возможных координат точек в этой четверти (x и y). */

namespace GeekBrains
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            Console.Write("Введите четверть: ");
            int n = Convert.ToInt32(Console.ReadLine());


            if(n == 1)
            {
                Console.WriteLine($"Дипазон возможных координат: x = {int.MaxValue}, y = {int.MaxValue}");
            }
            else if(n == 2)
            {
                Console.WriteLine($"Дипазон возможных координат: x = {int.MinValue}, y = {int.MaxValue}");
            }
            else if(n == 3)
            {
                Console.WriteLine($"Дипазон возможных координат: x = {int.MinValue}, y = {int.MinValue}");
            }
            else if(n == 4)
            {
                Console.WriteLine($"Дипазон возможных координат: x = {int.MaxValue}, y = {int.MinValue}");
            }
            else
            {
                Console.WriteLine("Нет такой четверти");
            }
        }
        
    }
}