namespace VladimirArtamnov
 {
    public static class HomeWork_Task_25
    {
        //Задача 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
        //3, 5 -> 243 (3⁵)
        //2, 4 -> 16

        public static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число A: ");
            int numberA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите натуральное число B, которое будет использоваться как степень для числа А: ");
            int numberB = Convert.ToInt32(Console.ReadLine());
            int finalNumber = Calculation(numberA, numberB);
            Print(c: finalNumber, b: numberB, a: numberA);
            
        }

        public static int Calculation(int a, int b)
        {
            int result = 1;
            for (int i=0; i < b; i++)
            {
                result = result * a;
            }
            return result;
        }

        public static void Print(int a, int b, int c)
        {
            Console.WriteLine($"Число А {a} в степени натурального числа B {b} будет равно {c}");
        }
        

    }
 }

