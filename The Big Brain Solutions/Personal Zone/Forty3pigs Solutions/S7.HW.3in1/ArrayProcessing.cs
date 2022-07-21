namespace Geekbrains
{
    class Arrays
    {
        public double[,] CreateArray(int rows, int columns, int start, int end)
        {
            double[,] arr = new double[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Random rand = new Random();
                    arr[i, j] = rand.Next(start, end) + rand.NextDouble();
                }
            }
            return arr;
        }
        public int[,] CreateArrayInt(int rows, int columns, int start, int end)
        {
            int[,] arr = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Random rand = new Random();
                    arr[i, j] = rand.Next(start, end);
                }
            }
            return arr;
        }
        public void PrintArray(double[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(string.Format("{0,8:N2} ", array[i, j])); // Выравнивание по 8 символам, 2 знака, после запятой
                }
                Console.WriteLine();
            }
        }
        public void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine();
                Console.Write("\t");
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(string.Format("{0,7} ", array[i, j])); // Выравнивание по 5 символам
                }
                Console.WriteLine();
            }
        }
    }
}