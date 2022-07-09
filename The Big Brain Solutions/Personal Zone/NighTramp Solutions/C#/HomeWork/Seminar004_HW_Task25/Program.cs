/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
namespace Task25
{
    class Program
    {
        static void ViewPow(int a, int b)
        {
            int result = 1;
            for (int i = 0; i < Math.Abs(b); i++)
            {
                result *= a;
            }
            Console.WriteLine(result);
        }
        static void Main(string[] asgs)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            ViewPow(a, b);
        }
    }
}