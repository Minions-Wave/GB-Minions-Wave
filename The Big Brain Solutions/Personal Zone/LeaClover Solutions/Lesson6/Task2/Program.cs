// Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)

// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

namespace GB.CSharp.Seminar6
{
    class task2
    {
        public static void Main(string[] args)
        {
            int N = new Random().Next(5, 11);
            int [] arrayX = GetArray(N);
            Console.WriteLine($"Сгенерирован следующий массив размера {N}: ");
            PrintArray(arrayX);
            Console.WriteLine(" ");
            int [] arrayClone = CloneArray(arrayX);
            Console.WriteLine("Копия массива: ");
            PrintArray(arrayClone);

        }

        public static int [] GetArray(int size)
        {
            int [] arrayN = new int [size];
            for (int i = 0; i < size; i++)
            {
                arrayN[i] = new Random().Next(-20, 21);
            }
            return arrayN;
        }

        public static int [] CloneArray(int [] arrayX)
        {
            int length = arrayX.Length;
            int [] arrayC = new int [length];
            for (int i = 0; i < length; i++)
            {
                arrayC[i] = arrayX[i];
            }
            return arrayC;
        }

         public static int [] PrintArray(int [] arrayP)
        {
           for(int i = 0; i < arrayP.Length; i++)
            {
                Console.Write($"{arrayP[i]}" + " | ");
            }
            return arrayP;
        }
    }
}