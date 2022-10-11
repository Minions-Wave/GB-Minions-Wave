/*
Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
namespace Task66
{
    class Program
    {
         static bool Check(int m, int n)
        {
            if (m < n) return true;
            return false;
        }
        static int FindSumN(int m, int n)
        {
            int size = n-m+1;
            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                sum += m + i;
            }
            return sum;
        }
        static void ViewSum(int sum)
        {
            Console.WriteLine("Sum = {0}", sum);
        }
        static void Main(string[] asgs)
        {
            Console.Write("Введите первое число: ");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int N = Convert.ToInt32(Console.ReadLine());
            if (Check(M,N))
            {
                ViewSum(FindSumN(M,N));
            }
        }
    }
}