/*
Дополнительная задача
Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы 
каждого элемента.
массив размером 2 x 2 x 2
12(0,0,0) 22(0,0,1)
45(1,0,0) 53(1,0,1)
*/
namespace Task60
{
    class Program
    {
        static Random random = new Random();
        static void View3DArray(int[,,] array)
        {
            Console.WriteLine(" ");
            Console.WriteLine("=====");
            Console.WriteLine(" ");
            int size = array.GetLength(0);
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    for (int k = 0; k < size; k++)
                    {
                        Console.WriteLine("{0}({1},{2},{3})", array[i,j,k], i, j, k);
                    }
                }
            }
        }
        static int[,,] RandomUniqueSymmetric3DArrayGenerator(int size)
        {
            if (size > 4 || size < 1)
            {
                int[,,] arr = new int[1, 1, 1];
                Console.WriteLine("Некорректный размер массива.");
                return arr;
            }
            int[,,] array = new int[size, size, size];
            int[] temp = new int[size * size * size];
            int g = 0;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    for (int k = 0; k < size; k++)
                    {
                        temp[g] = random.Next(10, 100);
                        for (int l = 0; l < g; l++)
                        {
                            if (temp[g] == temp[l])
                            {
                                random = new Random();
                                temp[g] = random.Next(10, 100);
                                l = 0;
                            }
                            //Console.WriteLine("{0}({1},{2},{3})", temp[g], i, j, k);
                            //Console.WriteLine("g = {0}, l = {1}", g, l);
                        }
                        array[i,j,k] = temp[g];
                        g++;
                    }
                }
            }
            return array;
        }
        static void Main(string[] asgs)
        {
            Console.WriteLine("Введите размер массива: ");
            View3DArray(RandomUniqueSymmetric3DArrayGenerator(
                Convert.ToInt32(Console.ReadLine())));
        }
    }
}