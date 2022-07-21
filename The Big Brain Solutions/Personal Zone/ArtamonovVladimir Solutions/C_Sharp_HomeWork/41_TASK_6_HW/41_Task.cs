namespace VladimirArtamnov
{
    public static class HomeWork_Task_41
    {
        //Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
        //0, 7, 8, -2, -2 -> 2

        public static void Main(string[] args)
        {
            Console.WriteLine("Введите сколько будет чисел будет в вашем ряду:");
            int rowLength = Convert.ToInt32(Console.ReadLine());
            int[] rowOfNumbers = new int[rowLength];
            int numbersAboveZero = ManualFillArray(rowOfNumbers);
            Console.Write("В вашем ряду чисел: ");
            PrintArray(rowOfNumbers, 0);
            Console.WriteLine();
            Console.WriteLine($"Количество чисел больше нуля равно {numbersAboveZero}");
        }

        public static int ManualFillArray(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Введите {i + 1} число:");
                array[i] = Convert.ToInt32(Console.ReadLine());
                if (array[i] > 0)
                {
                    count += 1;
                }
                Console.Clear();
            }
            return count;
        }

        public static void PrintArray(int[] incomingArray, int index)
        {
            if (index == incomingArray.Length)
            {
                return;
            }
            Console.Write(incomingArray[index]);
            Console.Write(", ");
            PrintArray(incomingArray, index + 1);
        }

    }
}


