namespace Geekbrains
{
    public class Tasks
    {
        public void Solution(TextAndMessage tam, int taskNumber)
        {
            switch (taskNumber)
            {
                case 1:
                    Task64(tam, taskNumber);
                    tam.TextWait();
                    break;
                case 2:
                    Task64(tam, taskNumber);
                    tam.TextWait();
                    break;
                case 3:
                    Task66(tam, taskNumber);
                    tam.TextWait();
                    break;
            }
        }

        private void Task64(TextAndMessage tam, int taskNumber)
        {
            tam.TaskText(taskNumber);
            tam.InputM();
            int.TryParse(Console.ReadLine(), out int m);
            tam.InputN();
            int.TryParse(Console.ReadLine(), out int n);
            int sum = 0;
            Console.WriteLine();

            //Console.SetCursorPosition((100 / 2 + 3 * (n - m)) / 2, 8);
            //Console.SetCursorPosition(20 + 11, 8);  // taskPosition + "Задача 68: " равное 11

            if (m < n)
            {
                for (int i = m; i <= n; i++)
                {
                    if (i != n) Console.Write(i + ", ");
                    else Console.Write(i);
                    sum += i;
                }

                //Console.SetCursorPosition(20 - 8, 12);              // taskPosition - ("Сумма чисел равна:" - "Задача 68: ") равное 8

                Console.WriteLine("\n\nСумма чисел равна: " + sum);
            }
            else Console.WriteLine("\n\nOoops!! ");
            SolReturnOrExit(tam);
        }

        private void Task66(TextAndMessage tam, int taskNumber)
        {
            tam.TaskText(taskNumber);
            tam.InputM();
            int.TryParse(Console.ReadLine(), out int m);
            tam.InputN();
            int.TryParse(Console.ReadLine(), out int n);

            int A(int m, int n)
            {
                if (m == 0)
                    return n + 1;
                else
                  if ((m > 0) && (n == 0))
                    return A(m - 1, 1);
                else if ((m > 0) && (n > 0))
                    return A(m - 1, A(m, n - 1));
                else return -1;
            }

            if ((m > 4 && n > 0) || (m > 3 && n > 5) || m < 0 || n < 0)

                Console.WriteLine("Oops!!");

            else Console.WriteLine("Результат функции: " + A(m, n));

            SolReturnOrExit(tam);
        }

        public void SolReturnOrExit(TextAndMessage tam)
        {
            tam.ReturnOrExit();
            ConsoleKeyInfo pressed = new ConsoleKeyInfo();
            pressed = Console.ReadKey();

            if (pressed.Key != ConsoleKey.Escape)
            {
                Homework.MainBody(tam);
            }
            else
            {
                Console.Clear();
                tam.Print("exit");
            }
        }
    }
}

