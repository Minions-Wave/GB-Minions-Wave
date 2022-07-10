namespace Geekbrains
{
    static public class Homework
    {
        static public void Main(string[] args)
        {
            Console.Clear();
            ConsoleKeyInfo choise;
            TaskText.PrintIntro();
            choise = Console.ReadKey();
            LunchTask(choise);
        }

        public static void LunchTask(ConsoleKeyInfo ch)
        {
            if (ch.Key == ConsoleKey.D1)
            {
                TaskText.Text34();
                TaskText.TextWait();
                var t1 = new Tasks();
                t1.solution34();
            }
            if (ch.Key == ConsoleKey.D2)
            {
                TaskText.Text36();
                TaskText.TextWait();
                var t2 = new Tasks();
                t2.solution36();
            }
            if (ch.Key == ConsoleKey.D3)
            {
                TaskText.Text38();
                TaskText.TextWait();
                var t3 = new Tasks();
                t3.solution38();
            }
            else return;
        }
    }
}