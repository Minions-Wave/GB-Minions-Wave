/*
Задача 64: Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""
*/
namespace Task64
{
    class Program
    {
        static bool Check(int m, int n)
        {
            if (m < n) return true;
            return false;
        }
        static int[] FillArrayN(int m, int n)
        {
            int size = n-m+1;
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = m + i;
            }
            return array;
        }
        static void ViewArray(int[] array)
        {
            Console.Write("[ ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.Write("]");
        }
        static void Main(string[] asgs)
        {
            Console.Write("Введите первое число: ");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int N = Convert.ToInt32(Console.ReadLine());
            if (Check(M,N))
            {
                ViewArray(FillArrayN(M,N));
            }
        }
    }
}