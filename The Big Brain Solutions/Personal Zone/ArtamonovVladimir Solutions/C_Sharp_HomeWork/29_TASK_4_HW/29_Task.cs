namespace VladimirArtamnov
{
    public static class HomeWork_Task_29
    {
        //Задача 29. Напишите программу, которая задаёт случайный массив случайного размера (от 5 до 10) элементов 
        //(значение элементов от 1 до 40) и выводит на экран массив квадратов этих чисел.
        //1, 2, 5, 7, 19 -> [2, 4, 25, 49, 361]
        //6, 1, 33 -> [36, 1, 1089]

        public static void Main(string[] args)
        {
            int length = GetRandomNumber(5, 11);
            Console.WriteLine($"Массив состоит из {length} чисел: ");
            int[] array = new int[length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = GetRandomNumber(1, 41);
            }
            Console.WriteLine($"Вводный массив:");
            PrintArray(array, 0);
            Console.WriteLine();
            int[] squareArray = Massive(array);
            Console.WriteLine($"Массив квадратов этих чисел:");
            PrintArray(squareArray, 0);
        }

        public static int GetRandomNumber(int first, int second)
        {
            int randomNumber = new Random().Next(first, second);
            return randomNumber;
        }

        public static int[] Massive(int[] arrayR)
        {
            for (int i = 0; i < arrayR.Length; i++)
            {
                arrayR[i] = Convert.ToInt32(Math.Pow(arrayR[i], 2));
                //Console.WriteLine(arrayR[i]);
            }
            return arrayR;
        }


        public static void PrintArray(int[] a, int index)
        {
            if (index == a.Length)
            {
                return;
            }
            Console.Write(a[index]);
            Console.Write(", ");
            PrintArray(a, index + 1);
        }

    }
}

