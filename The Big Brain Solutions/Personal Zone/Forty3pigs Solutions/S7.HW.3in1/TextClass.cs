namespace Geekbrains
{
    public static class TaskText
    {
        public static void TaskList()
        {
            TaskText.Text47();
            TaskText.Text50();
            TaskText.Text52();
        }
        public static void PrintIntro()
        {
            TaskList();
            Console.WriteLine("\nPress:     \x11 1 \x10  for start Task 47" +
                                   "\n \t   \x11 2 \x10  for start Task 50" +
                                   "\n \t   \x11 3 \x10  for start Task 52" +
                                    "\n\n\t\x11 Escape \x10  for quit\n");
        }
        /// <summary>
        /// Задача 47: Задайте двумерный массив размером m*n, заполненный случайными вещественными числами.
        /// </summary>
        public static void Text47()
        {
            Console.WriteLine("\nЗадача 47: Задайте двумерный массив размером m*n, заполненный случайными вещественными числами.");
        }
        /// <summary>
        /// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
        /// и возвращает значение этого элемента или же указание, что такого элемента нет.
        /// </summary>
        public static void Text50()
        {
            Console.WriteLine("\nЗадача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, ");
            Console.WriteLine("\t   и возвращает значение этого элемента или же указание, что такого элемента нет.");
        }
        /// <summary>
        /// Задача 52. Задайте двумерный массив из целых чисел. 
        /// Найдите среднее арифметическое элементов в каждом столбце.
        /// </summary>
        public static void Text52()
        {
            Console.WriteLine("\nЗадача 52: Задайте двумерный массив из целых чисел. ");
            Console.WriteLine("\t   Найдите среднее арифметическое элементов в каждом столбце.");
        }
        public static void TextWait()
        {
            Console.WriteLine("\nДля продолжения нажмите любую клавишу");
            Console.ReadKey();
        }
        public static void InputInvitation(string parameters)
        {
            Console.WriteLine("\n Caution: \nAll non numeric simbols will be equal to 0 \n" +
                              "All negative numbers will be positive");
            Console.Write($"\nEnter the {parameters} separated by a space or semicolon: ");
        }
    }
}