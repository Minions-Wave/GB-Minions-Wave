namespace Seminar9
{
    class Methods
    {
        public static void PrintCurrentList(List<int> numbers)
        {
            Console.Write("\n\n\tНатуральные числа в промежутке от первого и второго значений: ");
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                Console.Write($"{numbers[i]}, ");
            }
            Console.Write($"{numbers[numbers.Count - 1]}.\n");
        }

        public static void FillDataForList()
        {
            Console.Write(
                "\n\tПожалуйста введите минимальное значение элемента\n"
                    + "\tв виде натурального числа: "
            );
            string? startDigit = String.Empty;
            startDigit = Console.ReadLine();
            Console.Write(
                "\n\tПожалуйста введите максимальное значение элемента\n"
                    + "\tв виде натурального числа: "
            );
            string? endDigit = String.Empty;
            endDigit = Console.ReadLine();
            if (!String.IsNullOrEmpty(startDigit) && !String.IsNullOrEmpty(endDigit))
            {
                int startValue = Convert.ToInt32(startDigit.ToString());
                int endValue = Convert.ToInt32(endDigit.ToString());
                Decisions.FirstNumber = startValue;
                Decisions.SecondNumber = endValue;
            }
            else
            {
                Decisions.FirstNumber = 1;
                Decisions.SecondNumber = 2;
                Console.Write(
                    "\n\tВаш ввод не соответствует требованиям!\n"
                        + $"\tЗа значение нижней границы принято число: {Decisions.FirstNumber}"
                );
                Console.Write(
                    $"\n\tЗа значение верхней границы принято число: {Decisions.SecondNumber}"
                );
            }
        }

        public static bool ChoiseEscOrEnter(bool answer)
        {
            Console.WriteLine("\n\tВаш ввод не соответствует требованиям!");
            Console.Write(
                "\n\tПожалуста нажмите любую клавишу для повторения операции\n"
                    + "\tили Escape для выхода в основное меню: "
            );
            if (Console.ReadKey(true).Key == ConsoleKey.Escape)
            {
                Console.WriteLine("\n");
                return answer = true;
            }
            else
                return answer = false;
        }
    }
}
