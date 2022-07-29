namespace VladimirArtamnov
{
    public static class HomeWork_Task_36
    {
        //Задача 36. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
        //[3, 7, 23, 12] -> 19
        //[-4, -6, 89, 6] -> 0

        public static void Main(string[] args)
        {
            int length = GetRandomNumber(5, 11);
            Console.WriteLine($"Массив состоит из {length} чисел: ");
            int[] array = new int[length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = GetRandomNumber(-1000, 1000);
            }
            Console.WriteLine($"Вводный массив:");
            PrintArray(array, 0);
            Console.WriteLine();
            int result = NotEvenIndex(array);
            Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях равна {result}");
        }

        public static int GetRandomNumber(int first, int second)
        {
            int randomNumber = new Random().Next(first, second);
            return randomNumber;
        }

        public static int NotEvenIndex(int[] arrayR)
        {
            int sum = 0;
            for (int i = 1; i < arrayR.Length; i++)
            {
                if (i%2 != 0)
                {
                    sum += arrayR[i];
                }
                //Console.WriteLine(sum);
            }
            return sum;
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


