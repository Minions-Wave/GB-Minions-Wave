/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в 
двумерном массиве, и возвращает значение этого элемента или же указание, что 
такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
*/
namespace Task50
{
    class Program
    {
        static int[,] array = {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}};

        static bool CheckElement(int a, int b)
        {
            if (a > -1 && a <= array.GetUpperBound(0) && 
                b > -1 && b <= array.GetUpperBound(1)) return true;
            return false;
        }
        static void Main(string[] asgs)
        {
            Console.WriteLine("Введите индексы элемента массива:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if (CheckElement(a, b))
            {
                Console.WriteLine("Злачение элемента [{0},{1}] = {2}", a, b, array[a,b]);
            }
            else
            {
                Console.WriteLine("Элементы [{0},{1}] не найден", a, b);
            }

        }
    }
}