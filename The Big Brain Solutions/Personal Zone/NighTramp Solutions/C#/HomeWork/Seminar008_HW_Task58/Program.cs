/*
Задача 58: Задайте две матрицы. Напишите программу, которая выведет 
матрицу произведения элементов двух предыдущих матриц.
Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49
*/
namespace Task58
{
    class Program
    {
        static int[,] _array1 = {{1, 4, 7, 2}, 
                                 {5, 9, 2, 3}, 
                                 {8, 4, 2, 4},
                                 {5, 2, 6, 7}};
        static int[,] _array2 = {{1, 5, 8, 5}, 
                                 {4, 9, 4, 2}, 
                                 {7, 2, 2, 6},
                                 {2, 3, 4, 7}};                        
         static void ViewTwoDimensionalArray(int[,] array)
        {
            for (int i = 0; i <= array.GetUpperBound(0); i++) //row
            {
                Console.Write("[ ");
                for (int j = 0; j <= array.GetUpperBound(1); j++) //columns
                {
                    Console.Write("{0} ", array[i,j]);
                }
                Console.WriteLine("]");
            }
        }
        static int[,] Multiplication(int[,] array1, int[,] array2)
        {
            int rows, columns;
            //защита от дурака, работаем по минимальным размерам
            if (array1.GetLength(0) <= array2.GetLength(0)) rows = array1.GetLength(0);
            else rows = array2.GetLength(0);
            if (array1.GetLength(1) <= array2.GetLength(1)) columns = array1.GetLength(1);
            else columns = array2.GetLength(1);

            int[,] result = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i,j] = array1[i,j] * array2[i,j];
                }
            }
            return result;
        }
        static void Main(string[] asgs)
        {
            Console.WriteLine("Первый массив:");
            ViewTwoDimensionalArray(_array1);
            Console.WriteLine("Второй массив:");
            ViewTwoDimensionalArray(_array2);
            Console.WriteLine("Результат умножения элементов массивов:");
            ViewTwoDimensionalArray(Multiplication(_array1,_array2));
        }
    }
}