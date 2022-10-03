/*
Задача 23
Напишите программу, которая принимает на вход 
число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
namespace Task23
{
   
    static class CubeView
    {
        static public void ViewSequenceOfCubes(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                Console.Write(i * i * i);
                if (i < number) Console.Write(", ");
            }
        }

    }
    class Program
    {
        static void Main(string[] asgs)
        {
            CubeView.ViewSequenceOfCubes(Convert.ToInt32(Console.ReadLine()));
        }
    }
}