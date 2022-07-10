// Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие отрицательные, и наоборот.

// [-4, -8, 8, 2] -> [4, 8, -8, -2]

namespace S5T1
{
	class Program
	{
		public static void Main()
		{

			// Console.WriteLine("Введите числа через пробел");
			/*Console.ReadLine().Split().Select(int.Parse).ToArray();*/
            Console.WriteLine("Программа смены знака числа\n");
			Console.Write("Введите размер массива: ");
			int a = Convert.ToInt32(Console.ReadLine());
 			int[] b = new int[a];
 			int[] arr = new int[a];
 			Console.WriteLine();
 			Fill(arr);
 			
 			for(int i = 0; i < arr.Length; i++)
 			{
 				b[i] = arr [i];
 				if(arr[i] > 0)
 				{
 					arr[i] = -arr[i];
 				}
 				
 				else if(arr[i] < 0)
 				{
 					arr[i] = (arr[i] * (-1));
 				}
 				
 			}

 			Console.WriteLine("{0, 0} {1, 10}\n", "До", "После");
            for (int ctr = 0; ctr < arr.Length; ctr++)
            {
            	Console.WriteLine("{0,-7} {1}", arr[ctr], b[ctr]);
            }
		}
		public static void Fill(int[] nums)   
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = new Random().Next(-1000, 1000);
            }
        }
		
	}
}