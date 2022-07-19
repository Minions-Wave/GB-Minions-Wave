namespace Geekbrains
{
    static public class Homework7
    {
        static public void Main()
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
                Console.Clear();
                TaskText.Text47();
                //TaskText.TextWait();
                var t = new Task47();
                t.Solution();
            }
            if (ch.Key == ConsoleKey.D2)
            {
                Console.Clear();
                TaskText.Text50();
                //TaskText.TextWait();
                var t = new Task50();
                t.Solution();
            }
            if (ch.Key == ConsoleKey.D3)
            {
                Console.Clear();
                TaskText.Text52();
                //TaskText.TextWait();
                var t = new Task52();
                t.Solution();
            }
            if (ch.Key == ConsoleKey.Escape)
            {
                return;
            }
            else Main(); //return;
        }
    }
}