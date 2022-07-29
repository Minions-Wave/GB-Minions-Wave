namespace VladimirArtamnov
 {
    class HomeWork_Task_23
    {
        //Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
        //3 -> 1, 8, 27
        //5 -> 1, 8, 27, 64, 125
        
        // public static int GetRandomNumber(int first, int second)
        // {
        //     int randomNumber = new Random().Next(first, second);
        //     return randomNumber;
        // }

        public static void calculationOfSqrt(int number)
        {
             Console.Write($"{Math.Pow(number, 3)}, ");
        }

        public static void Main(string[] args)
        {
            Console.Write("Введите число до которого будут считаться куб каждого числа: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            for (i = 1; i <= number; i++)
            {
                calculationOfSqrt(i);
            }
        }
    }
 }

