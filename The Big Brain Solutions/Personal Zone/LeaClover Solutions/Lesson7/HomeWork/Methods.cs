using GBhomework7;

namespace GBhomework7
{
    class Methods
    {
        public string? str;
        Text result = new();
        
        public double [,] FillMatrix(double [,] matrixNew)
        {
            for(int i = 0; i < matrixNew.GetLength(0); i++)
            {
                for(int j = 0; j < matrixNew.GetLength(1); j++)
                {
                    matrixNew[i,j] = new Random().Next(-99, 100);
                    matrixNew[i,j] = matrixNew[i,j]/10;
                }
            }
            return matrixNew;
        }

        public double [,] PrintMatrix(double [,] matrix)
        {
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j] + " | ");
                }
                Console.WriteLine();
            }
            return matrix; 
        }
        public void GetArrayElement(double [,] matrix, string [] posMatrix)
        {
            int row = int.Parse((posMatrix[0]).ToString()) - 1;
            int column = int.Parse((posMatrix[1]).ToString()) - 1;
            if(row < matrix.GetLength(0) && column < matrix.GetLength(1))
            {
               result.task2result1(matrix, row, column);
            }
            else
            {
                result.task2result2();
            }
        }

        public void GetColumnAverage(double [,] matrix)
        {
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                double sum = 0;
                for(int i = 0; i < matrix.GetLength(0); i++)
                {
                    sum = sum + matrix[i,j];
                }
                double average = Math.Round(sum/matrix.GetLength(0), 1);
                result.task3result(average, j);
            }
        }
    }
}