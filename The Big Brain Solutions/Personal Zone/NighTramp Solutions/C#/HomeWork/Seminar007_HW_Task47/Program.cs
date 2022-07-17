/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными 
вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
namespace Task47
{
    class Program
    {
        static Random random = new Random();

        static double[,] RandomTwoDimensionalArrayGenerator()
        {
            Console.WriteLine("Введите m и n:");
            double[,] array = new double[Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i <= array.GetUpperBound(0); i++) //row
            {
                for (int j = 0; j <= array.GetUpperBound(1); j++) //columns
                {
                    array[i,j] = random.Next(-99,100) * 0.1;
                }
            }
            return array;
        }
        static void ViewTwoDimensionalArray(double[,] array)
        {
            for (int i = 0; i <= array.GetUpperBound(0); i++) //row
            {
                Console.Write("[");
                for (int j = 0; j <= array.GetUpperBound(1); j++) //columns
                {
                    Console.Write("{0} ", Math.Round(array[i,j], 1));
                }
                Console.WriteLine("]");
            }
        }
        static void Main(string[] asgs)
        {
            ViewTwoDimensionalArray(RandomTwoDimensionalArrayGenerator());
        }
    }
}