namespace Geekbrains
{
    public static class TaskText
    {
        public static void TaskList()
        {
            TaskText.Text34();
            TaskText.Text36();
            TaskText.Text38();
        }
        public static void PrintIntro()
        {
            TaskList();
            Console.WriteLine("\nPress:   1 for start task34 \n \t 2 for start task36 \n \t 3 for start task38 \nOr any other key for quit");
        }
        public static void Text34()
        {
            Console.WriteLine("\nЗадача 34: Задайте массив заполненный случайными положительными трёхзначными числами. ");
            Console.WriteLine("Напишите программу, которая покажет количество чётных чисел в массиве.");
        }
        public static void Text36()
        {
            Console.WriteLine("\nЗадача 36: Задайте одномерный массив, заполненный случайными числами.");
            Console.WriteLine("Найдите сумму элементов, стоящих на нечётных позициях.");

        }
        public static void Text38()
        {
            Console.WriteLine("\nЗадача 38: Задайте массив вещественных чисел.");
            Console.WriteLine("Найдите разницу между максимальным и минимальным элементов массива.");

        }
        public static void TextWait()
        {
            Console.WriteLine("\nДля продолжения нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}