/*
Задача 13: Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
namespace Task13
{
    class Program
    {
        static void ThirdNumberView(int number)
        {
            if (number / 100 > 0)
            {
                Console.Write((number / 100) % 10);
            }
            else
            {
                Console.Write("третьей цифры нет");
            }
        }
        
        static void Main(string[] asgs)
        {
            ThirdNumberView(Convert.ToInt32(Console.ReadLine()));
        }
    }
}