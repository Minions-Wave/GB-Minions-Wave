// Задача 15. Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным

namespace GeekBrains
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            Console.Write("Введите цифру, обозначающую день недели: ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            if(n > 0 && n < 6)
            {
                Console.WriteLine($"Это рабочий день");
            }
            else if(n > 5 && n < 8)
            {
                Console.WriteLine("Это выходной");
            }
            else
            {
                Console.WriteLine("В неделе 7 дней ;)");
            }
        }
       
    }
}

