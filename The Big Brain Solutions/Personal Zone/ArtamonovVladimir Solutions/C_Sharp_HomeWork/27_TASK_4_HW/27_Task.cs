namespace VladimirArtamnov
 {
    public static class HomeWork_Task_27
    {
        //Задача 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
        //452 -> 11
        //82 -> 10
        //9012 -> 12

        public static void Main(string[] args)
        {
            Console.WriteLine("Введите целое положительное число: ");
            string? inputText = Convert.ToString(Console.ReadLine());
            if (String.IsNullOrEmpty(inputText))
            {
                Console.WriteLine("Строка Null или Пустая!!!");
                return;
            }
            int[] numbersArray = Massive(inputText);
            //PrintArray(numbersArray, 0);
            int result = Sum(numbersArray);
            Print(inputText, result);      
            
        }

        public static int[] Massive(string text)
        {
            //Console.WriteLine(text);
            int[] array = new int[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                array[i] = Convert.ToInt32(text.Substring(i,1));
                //Console.WriteLine(numbersArray[i]);
            }
            return array;
        }

        public static int Sum(int [] array)
        {
            int sum = 0;
            for (int i=0; i < array.Length; i++)
            {
                sum = sum + array[i];
            }
            return sum;
        }

        public static void Print(string t, int r)
        {
            Console.WriteLine($"Сумма цифр в числе {t} равна {r}");
        }
        
        public static void PrintArray(int[] a, int index)
        {
            if (index == a.Length)
            {
                return;
            }
            Console.WriteLine(a[index]);
            PrintArray(a, index + 1);
        }

    }
 }


