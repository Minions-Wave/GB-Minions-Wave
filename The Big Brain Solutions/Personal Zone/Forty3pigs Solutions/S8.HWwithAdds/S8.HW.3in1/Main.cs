namespace Geekbrains
{
    static public class Homework8
    {
        static public void Main()
        {
            Console.Clear();
            ConsoleKeyInfo choise;
            TextAndMessage print = new TextAndMessage();
            print.PrintIntro();
            choise = Console.ReadKey();
            LunchTask(choise, print);
        }

        public static void LunchTask(ConsoleKeyInfo ch, TextAndMessage print)
        {
            if (ch.Key == ConsoleKey.D1)
            {
                Console.Clear();
                print.Text54();
                //print.TextWait();
                var t = new Task54();
                t.Solution(print);
            }
            if (ch.Key == ConsoleKey.D2)
            {
                Console.Clear();
                print.Text56();
                //print.TextWait();
                var t = new Task56();
                t.Solution(print);
            }
            if (ch.Key == ConsoleKey.D3)
            {
                Console.Clear();
                print.Text58();
                //print.TextWait();
                var t = new Task58();
                t.Solution(print);
            }
            if (ch.Key == ConsoleKey.Escape)
            {
                return;
            }
            else Main(); //return;
        }
    }
}
