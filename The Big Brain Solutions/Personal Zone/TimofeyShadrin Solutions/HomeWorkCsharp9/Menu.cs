namespace Seminar9
{
    class Menu
    {
        public static void Intro()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(
                "\n\t Приветствую! Выберете пожалуйста задачу для проверки!\n"
                    + "\t\t Для этого используйте клавишы вверх и вниз, затем подтвердите его кнопкой Enter.\n"
                    + "\n\n"
                    + "\t1. Задача No 64:\n"
                    + "\t\t Задайте значения M и N.\n"
                    + "\t\t Напишите программу, которая выведет все натуральные числа в промежутке от M до N.\n"
                    + "\n"
                    + "\t2. Задача No 66:\n"
                    + "\t\t Задайте значения M и N.\n"
                    + "\t\t Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.\n"
                    + "\n"
                    + "\t3. Задача No 68:\n"
                    + "\t\t Напишите программу вычисления функции Аккермана с помощью рекурсии.\n"
                    + "\t\t Даны два неотрицательных числа m и n.\n"
                    + "\n\n"
                    + "\t Выход из программы"
            );
            Console.ResetColor();
            Console.WriteLine();
        }

        private static void HorizontalLine(int left, int top, int length)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(left, top);
            Console.Write("+");
            for (int i = 0; i < length; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.ResetColor();
        }

        private static void VerticalLine(int left, int top, int height)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i <= height; i++)
            {
                Console.SetCursorPosition(left, top + i);
                Console.Write("|");
            }
            Console.ResetColor();
        }

        public static void Box(int left, int top, int lenght, int height)
        {
            HorizontalLine(left, top, lenght);
            VerticalLine(left, top + 1, height - 1);
            VerticalLine(left + lenght + 1, top + 1, height - 1);
            HorizontalLine(left, top + height, lenght);
            Console.SetCursorPosition(0, 0);
        }
    }
}
