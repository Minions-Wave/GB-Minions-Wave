// Задача 64: Задайте значения M и N.
// Напишите программу, которая выведет
// все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""
namespace DZ_64
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("\nПрограмма вывода всех натуральных чисел в промежутке от M до N");
            Console.Write("\nЗадайте M: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Задайте N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int[] arrayMN = new int[n - m + 1];
            FillArray(arrayMN, m);
            Console.WriteLine("M = {0}; N = {1} -> \"{2}\" ", m, n, string.Join(", ", arrayMN));

        }
        public static void FillArray(int[] someArray, int a)
        {
            for (int i = 0; i < someArray.Length; i++)
            {
                someArray[i] = a++;
            }
        }
    }
}