// Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)

// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

namespace GB.CSharp.Seminar6
{
    class task1
    {
        public static void Main(string[] args)
        {
            int N = new Random().Next(5, 11);
            int [] arrayX = GetArray(N);
            Console.WriteLine($"Сгенерирован следующий массив размера {N}: ");
            PrintArray(arrayX);
            Console.WriteLine(" ");
            int [] arrayFlip = FlipArray(arrayX);
            Console.WriteLine("Перевернули массив: ");
            PrintArray(arrayFlip);

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

        public static int [] FlipArray(int [] arrayF)
        {
            int length = arrayF.Length;
            int mid = length/2;
            int x;
            for (int i = 0; i < mid; i++)
            {
                x = arrayF[i];
                arrayF[i] = arrayF[length - 1 - i];
                arrayF[length - 1 - i] = x;
            }
            return arrayF;
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