namespace Geekbrains
{
    // interface ArrayMethods<T>
    // {
    //     void CreateAr(<T>)

    // }
    class Arrays
    {
        public static int AskSize()
        {
            Console.Write("\nEnter size of array: ");
            int.TryParse(Console.ReadLine(), out int size);
            return size;
        }
        // массив целых только с заданным кол-вом разрядов
        public int[] CreateArray(int size, int digitQuantity)
        {
            int[] array = new int[size];
            int start = Convert.ToInt32(Math.Pow(10, digitQuantity - 1));   // задаём разрядность массива
            int end = Convert.ToInt32(Math.Pow(10, digitQuantity));
            Console.WriteLine("\nArray generated: ");
            for (int i = 0; i < size; i++)
            {
                array[i] = new Random().Next(start, end);

                Console.Write($"{array[i]} ");
            }
            Console.WriteLine("");
            return array;
        }
        // массив целых в диапазоне от start до end-1
        public int[] CreateArray(int size)
        {
            int[] array = new int[size];
            int start = -999;
            int end = 1000;
            Console.WriteLine("\nArray generated: ");
            for (int i = 0; i < size; i++)
            {
                array[i] = new Random().Next(start, end);
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine("");
            return array;
        }
        // массив вещественных в диапазоне от start до end-1
        public double[] CreateArray(int size, bool d)
        // bool d - заглушка. Можно прикрутить отрезание десятичных знаков до некоторого значения
        {
            double[] array = new double[size];
            int start = -999;
            int end = 1000;
            Random rand = new Random();
            Console.WriteLine("\nArray generated: ");
            for (int i = 0; i < size; i++)
            {
                array[i] = rand.Next(start, end) + rand.NextDouble();

                Console.Write($"\n{array[i]} ");
            }
            Console.WriteLine("");
            return array;
        }
    }
}