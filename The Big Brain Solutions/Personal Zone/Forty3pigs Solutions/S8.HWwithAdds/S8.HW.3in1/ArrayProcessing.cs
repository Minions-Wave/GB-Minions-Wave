namespace Geekbrains
{
    ///<include file='info.xml' path='docs/ArrayProcessing/helps[@name="Arrays"]/*'/>
    class Arrays
    {
        ///<include file='info.xml' path='docs/ArrayProcessing/helps[@name="CreateArrayInt"]/*'/>
        public int[,] CreateArrayInt(int rows, int columns, int start, int end)
        {
            int[,] arr = new int[rows, columns];
            Random rand = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    arr[i, j] = rand.Next(start, end);
                }
            }
            return arr;
        }
        ///<include file='info.xml' path='docs/helps[@name="PrintArray"]/*'/>
        public void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine();
                Console.Write("  ");
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(string.Format("{0,3} ", array[i, j])); // Выравнивание по 5 символам
                }
                //Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}