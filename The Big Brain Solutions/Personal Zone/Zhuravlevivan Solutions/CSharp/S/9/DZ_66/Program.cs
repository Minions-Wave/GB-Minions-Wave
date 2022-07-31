// Задача 66: Задайте значения M и N.
// Напишите программу, которая найдёт
// сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
namespace DZ_64
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("\nПрограмма вывода суммы всех натуральных чисел в промежутке от M до N");
            Console.Write("\nЗадайте M: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Задайте N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int[] arrayMN = new int[n - m + 1];
            FillArray(arrayMN, m);
            Console.WriteLine("M = {0}; N = {1} -> {2} \n", m, n, arrayMN.Sum());

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