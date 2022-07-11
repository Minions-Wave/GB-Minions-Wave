/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
namespace Task38
{
    class Program
    {    
        private static Random random = new Random();
        
        public static double[] RandomRealNumbersArrayGenerator()
        {
            double[] array = new double[random.Next(5, 11)];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-9,10) + random.NextDouble();
                //Console.WriteLine(array[i]);
            }
            return array;
        }
        public static void ViewArrayAndSubOfMaxAndMin(double[] array)
        {
            double min = array.First();
            double max = array.First();
            Console.Write("[");
            for (int i = 1; i < array.Length; i++)
            {
                if (min > array[i]) min = array[i];
                if (max < array[i]) max = array[i]; 
                if (i != array.Length - 1)
                {
                    Console.Write("{0} ", Math.Round(array[i], 2));
                }
                else
                {
                    Console.Write("{0}] -> {1}", Math.Round(array[i], 2), Math.Round(max - min, 2));
                }
            }
        }
        static void Main(string[] asgs)
        {
            ViewArrayAndSubOfMaxAndMin(RandomRealNumbersArrayGenerator());
        }
    }
}