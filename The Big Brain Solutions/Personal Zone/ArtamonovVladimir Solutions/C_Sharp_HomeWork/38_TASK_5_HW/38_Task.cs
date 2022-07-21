namespace VladimirArtamnov
{
    public static class HomeWork_Task_38
    {
        //Задача 38. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
        //[3 7 22 2 78] -> 76
       
        public static void Main(string[] args)
        {
            int length = new Random().Next(5,10);
            Console.WriteLine($"Массив состоит из {length} чисел: ");
            double[] array = new double[length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = GetRandomNumber();
            }
            Console.WriteLine($"Вводный массив:");
            PrintArray(array, 0);
            Console.WriteLine();
            double result = Difference(array);
            Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {result}");
        }

        public static double GetRandomNumber()
        {
            double randomNumber = new Random().NextDouble()* new Random().Next(-100, 100);
            return randomNumber;
        }

        public static double Difference(double[] arrayR)
        {
            double minNumber = arrayR[0];
            double maxNumber = arrayR[0];
            double diff = 0;
            for (int i = 1; i < arrayR.Length; i++)
            {
                if (arrayR[i] > maxNumber)
                {
                    maxNumber = arrayR[i];
                }
                else if (arrayR[i] < minNumber)
                {
                    minNumber = arrayR[i];
                }
            }
            diff = maxNumber - minNumber;
            return diff;
        }


        public static void PrintArray(double[] a, int index)
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


