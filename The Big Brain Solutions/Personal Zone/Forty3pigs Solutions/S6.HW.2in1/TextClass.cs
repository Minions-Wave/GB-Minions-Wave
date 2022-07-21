namespace Geekbrains
{


    public static class TaskText
    {

        public static void TaskList()
        {
            TaskText.Text41();
            TaskText.Text43();

        }
        public static void PrintIntro()
        {
            TaskList();
            Console.WriteLine("\nPress:   1 for start task41 \n \t 2 for start task43 \nOr any other key for quit");
        }
        public static void Text41()
        {
            Console.WriteLine("\nЗадача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. ");
        }
        public static void Text43()
        {
            Console.WriteLine("\nЗадача 43: Напишите программу, которая найдёт точку пересечения двух прямых,");
            Console.WriteLine("заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; ");
            Console.WriteLine("значения b1, k1, b2 и k2 задаются пользователем.");
        }

        public static void TextWait()
        {
            Console.WriteLine("\nДля продолжения нажмите любую клавишу");
            Console.ReadKey();
        }

    }
}