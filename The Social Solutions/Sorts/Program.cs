namespace F3P
{
    static public class MyMain
    {
        static public void Main(string[] args)
        {
            int start = -20;
            int end = 99;

            Console.Write("Введите длину массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] unsorted = new int[n];

            FillArray(unsorted, start, end);

            Console.WriteLine("Сортированный массив: " + string.Join(", ", MySorts.BubbleSort(unsorted)));
            Console.WriteLine("Сортированный массив: " + string.Join(", ", MySorts.ShakerSort(unsorted)));
            Console.WriteLine("Сортированный массив: " + string.Join(", ", MySorts.CombSort(unsorted)));
            Console.WriteLine("Сортированный массив: " + string.Join(", ", MySorts.InsertSort(unsorted)));
            Console.WriteLine("Сортированный массив: " + string.Join(", ", MySorts.ChoiseSort(unsorted)));

            // Console.WriteLine("Сортированный массив: " + string.Join(", ", MySorts.QuickSort(unsorted)));
            // Console.WriteLine("Сортированный массив: " + string.Join(", ", MySorts.MergeSort(unsorted)));
            // Console.WriteLine("Сортированный массив: " + string.Join(", ", Pyramid.ShakerSort(unsorted)));
        }

        public static void FillArray(int[] arr, int start, int end)
        {
            for (int i = 0; i < arr.Length; i++)
                arr[i] = new Random().Next(start, end + 1);
            Console.WriteLine("Сгенерированный массив: " + string.Join(", ", arr));
        }
    }


}
