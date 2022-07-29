// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
namespace DZ_25
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Возведение числа A в натуральную степень B");
            Console.Write("Введите число А: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            // Решение через Math.Pow
            // int result = Convert.ToInt32(Math.Pow(a, b));
            // Console.WriteLine(result);
            
            // Решение через цикл
            int instep = 1;
            for (int i = 1; i <= b; i++)
            {
                instep = instep * a;
            }
            Console.WriteLine(instep);
        }

    }
}