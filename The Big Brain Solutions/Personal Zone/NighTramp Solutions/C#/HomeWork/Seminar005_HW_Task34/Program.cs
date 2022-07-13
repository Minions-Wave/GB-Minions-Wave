/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
namespace Task34
{
    class Program
    {    
        private static Random random = new Random();
        
        public static int[] RandomArrayGenerator()
        {
            int[] array = new int[random.Next(5, 11)];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100,1000);
            }
            return array;
        }
        public static void ViewArrayAndAmountOfEvenNumbers(int[] array)
        {
            int even = 0;
            Console.Write("[");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0) even++;
                if (i != array.Length - 1)
                {
                    Console.Write("{0}, ", array[i]);
                }
                else
                {
                    Console.Write("{0}] -> {1}", array[i], even);
                }
            }
        }
        static void Main(string[] asgs)
        {
            ViewArrayAndAmountOfEvenNumbers(RandomArrayGenerator());
        }
    }
}