// Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.

// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// Размер массива от 5 до 10
// Числа в массива от -20 до 20

namespace GB.CSharp.Seminar5
{
    class task2
    {
        static void Main(string[] args)
        {
            int N = new Random().Next(5, 11);
            int [] array = GetArray(N);
            Console.WriteLine($"Сгенерированный массив с {N} элементами: ");
            for(int i = 0; i<N; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Новый массив с противоположными знаками: ");
            int [] arrayCH = GetChangedArray(array);
            for(int i = 0; i < N; i++)
            {
                Console.Write(arrayCH[i] + " ");
            }
        }
        public static int [] GetArray(int n)
        {
            int [] ArrayMass = new int [n];
            int index = 1;
            while (index <= n)
            {
                ArrayMass[index-1] = new Random().Next(-20, 21);
                index = index + 1;
            }
            return ArrayMass;
        }

        public static int [] GetChangedArray(int [] arrayX)
        {
            int index = 1;
            while (index <= arrayX.Length)
            {
                arrayX[index-1] = -1 * arrayX[index-1];
                index = index + 1;
            }
            return arrayX;
        }
        
    }
}