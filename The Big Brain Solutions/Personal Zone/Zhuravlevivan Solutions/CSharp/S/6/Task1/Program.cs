// 1. Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1] [6 7 3 6] -> [6 3 7 6] 

namespace S6Task1
{
    class Program
    {
        public static void Main()
        {
            
            int[] arr = new int[new Random().Next(1,21)];
            Fill(arr);
            int[] rra = new int[arr.Length];
            
            for(int i = 0; i < arr.Length; i++)
            {
                rra[i] = arr[^(i+1)];
            }
            
            for (int ctr = 0; ctr < arr.Length; ctr++)
            {
            	Console.WriteLine("{0,-7} {1}", arr[ctr], rra[ctr]);
            }
        }

        public static void Fill(int[] nums)   
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = (new Random().Next(1, 100));
            }
        }

        public static void Print(int[] nums)
        {
        	for(int i = 0; i < nums.Length; i++)
        	{
        		Console.Write($"{nums[i]} ");
        	}
        }
    }
}
