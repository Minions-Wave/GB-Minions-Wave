// Задача 23
// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


namespace GeekBrains
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Программа вывода кубов числа");
            Console.Write("Введите число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] cubes = GetCube(a);

            for (int i = 0; i < cubes.Length; i++)
            {
                Console.Write( cubes[i] + " ");
            }
            
        }

         public static int[] GetCube(int n)
        {
            int[] cube = new int[n];
            for (int i = 1; i <= n; i++)
            {
                cube[i-1] = Convert.ToInt32(Math.Pow(i, 3));
            }
            return cube;
        }
    }
}