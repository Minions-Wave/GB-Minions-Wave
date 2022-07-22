// 2. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и
// единицами в случайном порядке. [1,0,1,1,0,1,0,0] 

namespace Seminar_4
{
    class Program
    {
        public static void Main()
        {
        
        int[] eigth_array = new int[8];
                
        for(int i = 0; i < eigth_array.Length; i++)
        {
            eigth_array[i] = new Random().Next(0, 2);
            Console.Write($"{eigth_array[i]} ");
        }

        }

    }
}