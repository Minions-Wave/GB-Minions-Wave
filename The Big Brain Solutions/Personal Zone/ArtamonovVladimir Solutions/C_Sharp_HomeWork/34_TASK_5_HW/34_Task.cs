namespace VladimirArtamnov
{
    public static class HomeWork_Task_34
    {
        //Задача 34. Задайте массив заполненный случайными положительными трёхзначными числами. 
        //Напишите программу, которая покажет количество чётных чисел в массиве. 
        //[345, 897, 568, 234] -> 2

        public static void Main(string[] args)
        {
            int length = GetRandomNumber(5, 11);
            Console.WriteLine($"Массив состоит из {length} чисел: ");
            int[] array = new int[length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = GetRandomNumber(100, 1000);
            }
            Console.WriteLine($"Вводный массив:");
            PrintArray(array, 0);
            Console.WriteLine();
            int result = EvenNumber(array);
            Console.WriteLine($"Количество чётных чисел в массиве равна {result}");
        }

        public static int GetRandomNumber(int first, int second)
        {
            int randomNumber = new Random().Next(first, second);
            return randomNumber;
        }

        public static int EvenNumber(int[] arrayR)
        {
            int count = 0;
            for (int i = 0; i < arrayR.Length; i++)
            {
                if (arrayR[i]%2 == 0)
                {
                    count++;
                }
                //Console.WriteLine(arrayR[i]);
            }
            return count;
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


