// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
namespace Geekbrains
{
    static public class Homework
    {
        static public void Main(string[] args)
        {

            //           Console.Clear();
            ConsoleKeyInfo choise;
            TaskText.PrintIntro();
            choise = Console.ReadKey();
            LunchTask(choise);
        }

        public static void LunchTask(ConsoleKeyInfo ch)
        {
            if (ch.Key == ConsoleKey.D1)
            {
                TaskText.Text41();
                TaskText.TextWait();
                var t = new Task41();
                t.Solution1();
                t.Solution2();
            }
            if (ch.Key == ConsoleKey.D2)
            {
                TaskText.Text43();
                TaskText.TextWait();
                var t = new Task43();
                t.Solution();
            }
            else return;
        }
    }

}