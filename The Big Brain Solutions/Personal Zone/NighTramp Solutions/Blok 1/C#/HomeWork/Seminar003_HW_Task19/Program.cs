/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет,
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
namespace Task19
{
    class Program
    {
        static void PalindromCheck(string text)
        {
            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            string reverseText= new string(charArray);
            if (text == reverseText)
            {
                Console.WriteLine("да");
            }
            else
            {
                Console.WriteLine("нет");
            }
        }
        
        static void Main(string[] asgs)
        {
            PalindromCheck(Console.ReadLine());
        }
    }
}