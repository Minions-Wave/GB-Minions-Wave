// Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементов массива.

// [3 7 22 2 78] -> 76

namespace GB.CSharp.Seminar5
{
    class task38
    {
        public static void Main(string[] args)
        {
            int N = new Random().Next(5, 11);
            double [] arrayX = GetArray(N);
            double [] arrayEnd = GetNewArray(arrayX);
            Console.WriteLine($"Сгенерирован следующий массив размера {N}: ");
            for(int i = 0; i < N; i++)
            {
                Console.Write($"{arrayEnd[i]}" + " | ");
            }
            Console.WriteLine();
            Console.Write($"Разница между максимальным и минимальным элементами равна {GetDiff(GetMin(arrayEnd),GetMax(arrayEnd))}");
        }

        public static double[] GetArray(int size)
        {
            double[] arrayN = new double [size];
            for (int i = 0; i < size; i++)
            {
                arrayN[i] = new Random().Next(-2000, 2001);
            }
            return arrayN;
        }

        public static double [] GetNewArray(double [] arrayE)
        {
            for (int i = 0; i < arrayE.Length; i++)
            {
                arrayE[i] = arrayE[i]/100;
            }
            return arrayE;
        }

         public static double GetMax(double [] arrayMax)
        {
            double max = arrayMax[0];
            for (int i = 1; i < arrayMax.Length; i++)
            {
                if(arrayMax[i]>max)
                {
                    max = arrayMax[i];
                }
            }
            return max;
        }

        public static double GetMin(double [] arrayMin)
        {
            double min = arrayMin[0];
            for (int i = 1; i < arrayMin.Length; i++)
            {
                if(arrayMin[i]<min)
                {
                    min = arrayMin[i];
                }
            }
            return min;
        }

        public static double GetDiff(double min, double max)
        {
            return max-min;
        }
    }
}