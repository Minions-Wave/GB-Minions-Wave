namespace VladimirArtamnov
 {
    class HomeWork_Task_10
    {
        //Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
        //456 -> 5
        //782 -> 8
        //918 -> 1
        
        public static int GetRandomNumber(int first, int second)
        {
            int randomNumber = new Random().Next(first, second);
            return randomNumber;
        }
        
        public static void Main(string[] args)
        {
            int number = GetRandomNumber(100,1000);
            string array = Convert.ToString(number);
            int secondChar = Convert.ToInt32(array[1].ToString());
            Console.WriteLine($"Вторая цифра в трехзначном {number} является {secondChar}");

        }
    }
 }
