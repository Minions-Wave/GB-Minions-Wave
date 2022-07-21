namespace VladimirArtamnov
{
    class HomeWork_Task_13
    {
        //Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
        //645 -> 5
        //78 -> третьей цифры нет
        //32679 -> 6

        public static int GetRandomNumber(int first, int second)
        {
            int randomNumber = new Random().Next(first, second);
            return randomNumber;
        }

        public static void Main(string[] args)
        {
            int number = GetRandomNumber(1, 10000);
            int numberLen = 3;
            string array = Convert.ToString(number);
            if (numberLen <= array.Length)
            {
                int thirdChar = Convert.ToInt32(array[2].ToString());
                Console.WriteLine($"Третьей цифрой в числе {number} является {thirdChar}");

            }
            else
            {
                Console.WriteLine($"Третьей цифры в числе {number} нет!");
            }

        }
    }
}