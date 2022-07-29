// Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.

// массив [6, 7, 19, 345, 3] -> нет
// массив [6, 7, 19, 345, 3] -> да

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
            Console.WriteLine($"Сгенерирован массив с {N} элементами");
            Console.WriteLine("Введите число и мы проверим есть ли оно в массиве");
            int number = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i<N; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine(" ");
            

            if(GetMassege(array, N, number) == true)
            {
                Console.WriteLine($"В данном массиве есть число {number}");
            }
            else
            {
                Console.WriteLine($"В данном массиве нет числа {number}");
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

        public static bool GetMassege(int [] arrayM, int size, int num)
        {
            int index = 1;
            while(index <= size)
            {
                if(arrayM[index-1]!=num)
                {
                    if(arrayM[index-1]!=num && index==size)
                    {
                        return false;
                    }
                    index = index + 1;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
    }
}