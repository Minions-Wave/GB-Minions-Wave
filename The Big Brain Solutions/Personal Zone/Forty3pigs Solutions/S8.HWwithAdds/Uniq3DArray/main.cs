// Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// массив размером 2 x 2 x 2

// 12(0,0,0) 22(0, 0, 1)
// 45(1, 0, 0) 53(1, 0, 1)

namespace Geekbrains
{
    static public class Homework
    {
        static public void Main(string[] args)
        {
            Console.WriteLine("Введите ширину массива");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите высоту массива");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите глубину массива");
            int z = Convert.ToInt32(Console.ReadLine());
            int[,,] arr = new int[x, y, z];
            int value = 10;
            if (x * y * z < 89)
            {
                Console.WriteLine("\nУсловия соблюдены, значения уникальны :)");
                CreateArray(arr, value);
                PrintArray(arr);
                Console.WriteLine("Нажми на кнопку, полчишь результат"
                                + " твоя мечта осущеcтвится...");
                Console.ReadKey();

                Console.WriteLine("А вот тут какой-никакой рандом");
                int[] rand2Digits = new int[90];
                randomizedDigits(rand2Digits);
                CreateRandArray(arr, rand2Digits, 0);
                PrintArray(arr);

            }
            else { Console.WriteLine("I don't have so many unique 2digit numbers"); }

        }

        public static void CreateArray(int[,,] array, int value)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        array[i, j, k] = value++;
                    }
                }
            }
        }

        public static void PrintArray(int[,,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine();
                    Console.Write("  ");
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        Console.Write($"{array[i, j, k]}({i},{j},{k})  ");
                    }
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        public static void randomizedDigits(int[] rand1D)
        {
            Random rand = new Random();
            int val, ind1, ind2;
            for (int i = 0; i < 90; i++)
            {
                rand1D[i] = i + 10;
            }
            for (int i = 0; i < 8100; i++)
            {
                ind1 = rand.Next(0, 90);
                ind2 = rand.Next(0, 90);

                val = rand1D[ind1];
                rand1D[ind1] = rand1D[ind2];
                rand1D[ind2] = val;
            }
        }

        public static void CreateRandArray(int[,,] array, int[] randDig, int val)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {

                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        array[i, j, k] = randDig[val++];
                    }
                }
            }
        }

    }
}
