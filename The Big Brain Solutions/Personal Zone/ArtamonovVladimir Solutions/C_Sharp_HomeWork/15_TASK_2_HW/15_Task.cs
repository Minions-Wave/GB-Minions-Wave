namespace VladimirArtamnov
{
    class HomeWork_Task_15
    {
        //Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
        //6 -> да
        //7 -> да
        //1 -> нет

        public static int GetRandomNumber(int first, int second)
        {
            int randomNumber = new Random().Next(first, second);
            return randomNumber;
        }

        public static void Main(string[] args)
        {
            int number = GetRandomNumber(1, 8);
            if (number == 6 || number == 7)
            {
                Console.WriteLine($"{number} день недели является выходным!");

            }
            else
            {
                Console.WriteLine($"{number} день недели НЕ является выходным!");
            }

        }
    }
}