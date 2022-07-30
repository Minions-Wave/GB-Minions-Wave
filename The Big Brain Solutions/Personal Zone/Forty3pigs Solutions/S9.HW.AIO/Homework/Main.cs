namespace Geekbrains
{
    static public class Homework
    {
        static public void Main()
        {

            TextAndMessage tam = new TextAndMessage();
            Console.SetWindowSize(100, 60);
            tam.Print("logo");
            MainBody(tam);

        }

        static public void MainBody(TextAndMessage tam)
        {
            Console.Clear();
            Drow drow = new Drow();
            Tasks task = new Tasks();
            tam.Intro();
            int? choise;
            choise = drow.Navigation(tam.GetTaskListCount());
            Console.Write(choise);
            Console.Write(tam.GetTaskListCount());
            if (choise != null && choise < tam.GetTaskListCount())
            {
                int ch = Convert.ToInt32(choise);
                task.Solution(tam, ch + 1);
            }
            else if (choise == tam.GetTaskListCount())
            {
                Console.Clear();
                tam.Print("exit");
            }
        }
    }

}