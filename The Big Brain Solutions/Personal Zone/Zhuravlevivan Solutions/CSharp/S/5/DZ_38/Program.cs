// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементом массива.

// [3 7 22 2 78] -> 76

namespace DZ_38
{
	class Program
	{
		public static void Main()
		{


			double[] arr_float = new double[new Random().Next(1, 20)];
			Fill(arr_float);
			Console.WriteLine("Массив вещественных чисел");
			Print(arr_float);
			double min = arr_float.Min();
			double max = arr_float.Max();

			Console.WriteLine($"\nMin: {Math.Round(min, 4)}");
			Console.WriteLine($"Max: {Math.Round(max, 4)}");
			Console.WriteLine($"{Math.Round((max - min), 4)} - Разница между максимальным и минимальным элементом массива");
		}

		public static void Fill(double[] nums)   
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = (new Random().NextDouble()*100);
            }
        }

        public static void Print(double[] nums)
        {
        	for(int i = 0; i < nums.Length; i++)
        	{
        		Console.WriteLine($"{Math.Round(nums[i], 4)} ");
        	}
        }
	}
}