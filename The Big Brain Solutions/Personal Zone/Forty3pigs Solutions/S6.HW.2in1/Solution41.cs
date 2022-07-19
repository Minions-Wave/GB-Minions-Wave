namespace Geekbrains
{
    public class Task41
    {
        int M = 5;
        int count = 0;
        int result = 0;
        public void Solution1()
        {
            Console.WriteLine("\nEnter 5 numbers");
            while (count < M && int.TryParse(Console.ReadLine(), out int num))
            {
                if (num > 0)
                {
                    result++;
                }
                count++;
            }
            Console.WriteLine($"You entered {result} numbers greater than 0");
            count = 0;  // обнуляем переменные для Solution2
            result = 0;
        }

        public void Solution2()
        {
            Console.Write($"Enter {count + 1} number: ");
            if (count == M)
            {
                Console.Write($"You entered {result} numbers greater than 0");
                return;
            }

            if (int.TryParse(Console.ReadLine(), out int num))
            {
                if (num > 0)
                {
                    result++;
                }

                count++;
                Solution2();
            }
            else Console.Write("Wrong input");
        }
    }
}