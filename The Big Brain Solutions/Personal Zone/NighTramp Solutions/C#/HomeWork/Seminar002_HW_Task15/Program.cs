/*
Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
namespace Task15
{
    class Program
    {
        static void WeekendCheck(int numberOfDay)
        {
            if (numberOfDay > 0 && numberOfDay < 8)
            {
                if (numberOfDay > 5)
                {
                    Console.Write("да");
                }
                else
                {
                    Console.Write("нет");
                }
            }
            else
            {
                Console.Write("Некорректное входное значение.");
            }
        }
        
        static void Main(string[] asgs)
        {
            WeekendCheck(Convert.ToInt32(Console.ReadLine()));
        }
    }
}