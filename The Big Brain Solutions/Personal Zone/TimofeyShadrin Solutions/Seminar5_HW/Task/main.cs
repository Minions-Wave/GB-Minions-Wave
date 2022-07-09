namespace Task
{
    class Program
    {
        public static void Main(string[] args)
        {
            string? answer = "0";
            while (true)
            {
                if (answer == "0")
                {
                    Console.Clear();
                    Menu list = new();
                    list.returnMenu0();
                    answer = Console.ReadLine();
                    if (!String.IsNullOrEmpty(answer))
                        answer = answer.ToLower();
                }
                else if (answer == "1")
                {
                    Task34 GotAnswerTask34 = new();
                    GotAnswerTask34.returnTask34();
                    Console.ReadKey();
                    answer = "0";
                }
                else if (answer == "2")
                {
                    Task36 GotAnswerTask36 = new();
                    GotAnswerTask36.returnTask36();
                    Console.ReadKey();
                    answer = "0";
                }
                else if (answer == "3")
                {
                    Console.Clear();
                    Console.WriteLine("Вы хотите заполнить массив сами? Y/n: ");
                    string? ask = Console.ReadLine();
                    if (!String.IsNullOrEmpty(ask))
                        answer = answer.ToLower();
                    if (ask == "n")
                    {
                        Task38 GotAnswerTask38 = new();
                        GotAnswerTask38.returnTask38();
                        Console.ReadKey();
                        answer = "0";
                    }
                    else if (ask == "y")
                    {
                        try
                        {
                            Task38manual GotAnswerTask38Manual = new Task38manual();
                            GotAnswerTask38Manual.returnTask38manual();
                            Console.ReadKey();
                            answer = "0";
                        }
                        catch
                        {
                            Console.WriteLine("Пожалуйста введите число, которое удовлетворяет условиям!");
                            Console.ReadKey();
                            answer = "3";

                        }

                    }
                    else answer = "3";

                }
                else if (answer == "q")
                    break;
                else
                    answer = "0";
            }
            Console.Clear();
            Console.WriteLine();
        }
    }
}
