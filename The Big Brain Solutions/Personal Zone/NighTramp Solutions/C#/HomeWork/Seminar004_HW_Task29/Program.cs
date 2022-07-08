/*
Задача 29: Напишите программу, которая задаёт 
случайный массив случайного размера (от 5 до 10) 
элементов (значение элементов от 1 до 40) и выводит 
на экран массив квадратов этих чисел.
1, 2, 5, 7, 19 -> [2, 4, 25, 49, 361]
6, 1, 33 -> [36, 1, 1089]
*/
namespace Task29
{
    class Program
    {
        static Random random = new Random();
        static int[] FullRandomArrayGenerator()
        {
            int[] array = new int[random.Next(5,11)]; //[5, 10]
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(40) + 1; //[1, 40]
            }
            return array;
        }
        static void ViewArray(int[] array)
        {
            Console.Write("Массив: [");
            for (int i = 0; i < array.Length-1; i++)
            {
                Console.Write("{0}, ", array[i]);
            }
            Console.WriteLine("{0}]", array.Last());
        }
        static void ViewArray(int[] array, int degree)
        {
            Console.Write("Массив: [");
            for (int i = 0; i < array.Length-1; i++)
            {
                Console.Write("{0}, ", Math.Pow(array[i], degree));
            }
            Console.WriteLine("{0}]", Math.Pow(array.Last(), degree));
        }
            
        static void Main(string[] asgs)
        {
            int[] array = FullRandomArrayGenerator();
            ViewArray(array);
            ViewArray(array, 2);
        }
    }
}