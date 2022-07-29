// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


namespace GB.CSharp.Seminar5
{
    class Task34
    {
        public static void Main(string[] args)
        {
            int N = new Random().Next(5, 11);
            int [] array = GetArray(N);
            Console.WriteLine($"Сгенерирован массив с {N} трехзначными элементами: ");
            for(int i = 0; i<N; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine(" ");
            Console.WriteLine($"В данном массиве количество четных чисел равно {GetCount(array, N)}!");
        }
        public static int [] GetArray(int size)
        {
            int [] arrayN = new int [size];
            for(int i = 0; i<size; i++)
            {
                arrayN[i] = new Random().Next(100, 1000);
            }
            return arrayN;
        }

        public static int GetCount(int [] arrayC, int size)
        {
            int count = 0;
            int i = 0;
            while(i<size)
            {
                if(arrayC[i]%2==0)
                {
                    count++;
                    i++;
                }
                else
                {
                    i++;
                }
            }
            return count;
        }
    }
}