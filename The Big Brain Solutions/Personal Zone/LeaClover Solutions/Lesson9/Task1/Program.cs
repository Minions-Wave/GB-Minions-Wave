// Из двумерного массива целых чисел удалить строку и столбец, 
// на пересечении которых расположен наименьший элемент.

namespace GB.CSharp.Seminar9
{
    class task1
    {
        public static void Main(string[] args)
        {
            int[,] matrix = new int[3, 4];
            FillArray(matrix);
            PrintArray(matrix);
            int[] pos = GetMinElement(matrix);
            Console.WriteLine();
            Console.WriteLine($"Индексы минимального элемента {pos[0]}-строка и {pos[1]}-столбец");
            int[,] matrix2 = GetNewArray(matrix, pos);
            PrintArray(matrix2);
        }

        public static int[,] FillArray(int[,] matr)
        {
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    matr[i, j] = new Random().Next(1, 9);
                }
            }
            return matr;
        }

        public static int[,] PrintArray(int[,] matr)
        {
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    Console.Write(matr[i, j] + " | ");
                }
                Console.WriteLine();
            }
            return matr;
        }

        public static int[] GetMinElement(int[,] matr)
        {
            int min = matr[0, 0];
            int[] position = new int[2];
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    if (min > matr[i, j])
                    {
                        min = matr[i, j];
                        position[0] = i;
                        position[1] = j;
                    }
                }
            }
            return position;
        }
        public static int[,] GetNewArray(int[,] matr, int[] position)
        {
            // int row = 0;
            // int column = 0;
            int[,] m = new int[matr.GetLength(0)-1, matr.GetLength(1)-1];
            int row = 0;
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                int column = 0;
                if (i != position[0] && row < m.GetLength(0))
                {
                    
                    for (int j = 0; j < matr.GetLength(1); j++)
                    {
                        if (j != position[1] && column < m.GetLength(1))
                        {
                            m[row, column] = matr[i, j];
                            column++;
                        }
                    }
                    row++;
                }
                Console.WriteLine();
            }
            return m;
        }
    }
}