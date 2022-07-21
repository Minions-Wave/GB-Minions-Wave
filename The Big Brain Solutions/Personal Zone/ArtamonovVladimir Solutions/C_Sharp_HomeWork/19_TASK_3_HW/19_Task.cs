namespace VladimirArtamnov
 {
    class HomeWork_Task_19
    {
        //Задача 19. ННапишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
        //14212 -> нет
        //12821 -> да
        //23432 -> да
        
        // public static int GetRandomNumber(int first, int second)
        // {
        //     int randomNumber = new Random().Next(first, second);
        //     return randomNumber;
        // }

        public static void GetIntputArray(int[] massive, int num)
        {
            int lastI = massive.Length;
            int i = 0;
            for (i = 0; i < lastI; i++)
            {
            Console.WriteLine($"Введите {i+1} Цифру для заполнения создания числа из {num} цифр: ");
            massive[i] = Convert.ToInt32(Console.ReadLine());
            }
            //return array;
        }

        // public static void PrintArray(int[] ar)
        // {
        //     int lastId = ar.Length;
        //     int i = 0;
        //     for (i = 0; i < lastId; i++)
        //     {
        //     Console.Write(ar[i]);
        //     }
        // }

        public static void checkPolindrom(int[] col)
        {
            int lastIndex = col.Length;
            int i = 0;
            while (i < lastIndex - (i + 1))
            {
                if (col[i] != col[lastIndex - (i + 1)])
                {
                    //Console.WriteLine($"{col[i]} and {col[lastIndex - (i + 1)]}");
                    Console.WriteLine($"Число {string.Join("",col)} не Полиндром!!!");
                    break;
                }
                else
                {
                    //Console.WriteLine($"{col[i]} and {col[lastIndex - (i + 1)]}");
                    i++;
                }
            
                if (i == lastIndex - (i + 1))
                {
                    Console.WriteLine($"Число {string.Join("",col)} Полиндром!!!");
                }
            }
        }
        
        public static void Main(string[] args)
        {
            int number = 5;
            int[] array = new int[number];
            GetIntputArray(array, number);
            //PrintArray(array);
            checkPolindrom(array);
        }
    }
 }
