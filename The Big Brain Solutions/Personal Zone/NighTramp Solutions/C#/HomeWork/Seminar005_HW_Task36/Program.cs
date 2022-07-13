/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
namespace Task36
{
    class Program
    {    
        private static Random random = new Random();
        
        public static int[] RandomArrayGenerator()
        {
            int[] array = new int[random.Next(5, 11)];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-9,10);
            }
            return array;
        }
        public static void ViewArrayAndSumOfUnevenNumbers(int[] array)
        {
            int sumUnevenNumbers = 0;
            Console.Write("[");
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0) sumUnevenNumbers += array[i];
                if (i != array.Length - 1)
                {
                    Console.Write("{0}, ", array[i]);
                }
                else
                {
                    Console.Write("{0}] -> {1}", array[i], sumUnevenNumbers);
                }
            }
        }
        static void Main(string[] asgs)
        {
            ViewArrayAndSumOfUnevenNumbers(RandomArrayGenerator());
        }
    }
}