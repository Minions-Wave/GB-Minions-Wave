// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


namespace GB.CSharp.Seminar5
{
    class Task36
    {
        public static void Main(string[] args)
        {
            int N = new Random().Next(5, 11);
            int [] array = GetArray(N);
            Console.WriteLine($"Сгенерирован массив с {N} элементами: ");
            for(int i = 0; i<N; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine(" ");
            Console.WriteLine($"Сумма элементов стоящих на нечетных позициях массива равна {GetSum(array, N)}!");
        }
        public static int [] GetArray(int size)
        {
            int [] arrayN = new int [size];
            for(int i = 0; i<size; i++)
            {
                arrayN[i] = new Random().Next(-100, 101);
            }
            return arrayN;
        }

        public static int GetSum(int [] arrayS, int size)
        {
            int sum = 0;
            int i = 0;
            while(i<size)
            {
                if(i%2!=0)
                {
                    sum = sum + arrayS[i];
                    i++;
                }
                else
                {
                    i++;
                }
            }
            return sum;
        }
    }
}